using System;
using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo: ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands() {
            var commands = new List<Command>
            {
                new Command{Id=1,HowTo="test",Line="test",Platform="test"},
                new Command{Id=2,HowTo="test",Line="test",Platform="test"},
                new Command{Id=3,HowTo="test",Line="test",Platform="test"}
            };

            return commands;
        }
         public Command GetCommandById(int id) {
             return new Command{Id=1,HowTo="test",Line="test",Platform="test"};
         }
    }
}