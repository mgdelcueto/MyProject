using System.Linq;
using System.Collections.Generic;

namespace MyProject.Models {
    public class DataSource {
        private MyProjectDBContext _dbContext=new MyProjectDBContext();
        public DataSource(MyProjectDBContext dbContext) {
            _dbContext = dbContext;
        }
        public static IList<Months> GetMonths() {
            //var result = _months.Values.ToList();
            //result.ForEach(p => p.Type = _productTypes[p.TypeID]);
            var dbContext = new MyProjectDBContext();
            var result = dbContext.Months.OrderBy(Months => Months.MoNum).ToList();
            return result;
        }
        public static IList<Periods> GetPeriods() {
            //var result = _months.Values.ToList();
            //result.ForEach(p => p.Type = _productTypes[p.TypeID]);
            var dbContext = new MyProjectDBContext();
            var result = dbContext.Periods.OrderBy(Periods => Periods.PerNum).ToList();
            return result;
        }
        public Months GetMonthsByID(int id) {
            var dbContext = new MyProjectDBContext();
            var result = dbContext.Months
                .SingleOrDefault(u => u.MoId.Equals(id));
                return result;
        }

    }
}