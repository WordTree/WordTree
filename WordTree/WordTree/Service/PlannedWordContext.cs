using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordTree.Model;

namespace WordTree.Service
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    class PlannedWordContext:DbContext
    {
        public PlannedWordContext():base("PlannedWordDataBase")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<PlannedWordContext>());
        }

        public DbSet<PlannedWord> PlannedWords { get; set; }

    }
}
