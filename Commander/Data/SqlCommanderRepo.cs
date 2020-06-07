using System;
using System.Linq;
using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class SqlCommanderRepo: ICommanderRepo
    {
        private readonly CommanderContext _context;
        public SqlCommanderRepo(CommanderContext context)
        {
            _context=context;
        }

        public void CreateCommand(Command cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Commands.Add(cmd);
        }

        public IEnumerable<Command> GetAllCommands() {
            var commands = new List<Command>
            {
                new Command{Id=1,HowTo="test",Line="test",Platform="test"},
                new Command{Id=2,HowTo="test",Line="test",Platform="test"},
                new Command{Id=3,HowTo="test",Line="test",Platform="test"}
            };

            return _context.Commands.ToList();
        }
         public Command GetCommandById(int id) {
             return _context.Commands.FirstOrDefault(p => p.Id == id);
         }

        public bool SaveChanges()
        {   
            return (_context.SaveChanges() >= 0);
        }
    }
}