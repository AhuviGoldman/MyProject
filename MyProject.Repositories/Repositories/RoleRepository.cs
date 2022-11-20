using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Entities;


namespace MyProject.Repositories.Repositories
{
   public  class RoleRepository : IRoleRepository
    {
        private readonly IContext _context;

        public RoleRepository(IContext context)
        {
            _context = context;
        }

        public Role Add(int id, string name, string description)
        {
            Role r = new Role(id, description, name);
            _context.Roles.Add(r);
            return r;
        }

        public void Delete(int id)
        {
            _context.Roles.Remove(_context.Roles.Find(r => r.Id == id));
        }

        public List<Role> GetAll()
        {
            return _context.Roles;
        }

        public Role GetById(int Id)
        {
            return _context.Roles.Find(r => r.Id == Id);
        }

        public Role Update(Role c)
        {
            if (_context.Roles.Find(r => r.Id == c.Id) != null)
            {
                _context.Roles.Find(r => r.Id == c.Id).Name = c.Name;
                _context.Roles.Find(r => r.Id == c.Id).Description = c.Description;
            }
            return c;
        }
    }
}
