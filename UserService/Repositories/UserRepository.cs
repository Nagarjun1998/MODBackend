using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Context;
using UserService.Models;

namespace UserService.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _context;
        public UserRepository(UserContext context)
        {
            _context = context;
        }
        public void Add(Userdtl item)
        {
            _context.Userdtls.Add(item);
            _context.SaveChanges();
        }
        public IEnumerable<Userdtl> GetAll()
        {
            return _context.Userdtls.ToList();
        }

        public void Delete(string id)
        {
            var item = _context.Userdtls.Find(id);
            _context.Userdtls.Remove(item);
            _context.SaveChanges();
        }

        public void ResetPassword(string email,string newpass)
        {
            var obj = _context.Userdtls.SingleOrDefault(i => i.Email == email);
            obj.Password = newpass;
            _context.SaveChanges();

        }

        public void User_Block(string id)
        {
            var item = _context.Userdtls.Find(id);
            if(item.Active=="True")
            {
                item.Active = "False";
            }
            else
            {
                item.Active = "True";
            }
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public IEnumerable<MentorDtl> SearchMentor(string technology , string timeslot)
        {
            var obj = _context.MentorDtls.Where(s => s.Technologies == technology || s.TimeSlot == timeslot).ToList();
            return obj;

        }

        public void Update(Userdtl item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
