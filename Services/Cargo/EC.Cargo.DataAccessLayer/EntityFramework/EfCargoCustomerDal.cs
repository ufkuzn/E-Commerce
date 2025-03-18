using EC.Cargo.DataAccessLayer.Abstract;
using EC.Cargo.DataAccessLayer.Concrete;
using EC.Cargo.DataAccessLayer.Repositories;
using EC.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC.Cargo.DataAccessLayer.EntityFramework
{
    public class EfCargoCustomerDal:GenericRepository<CargoCustomer>, ICargoCustomerDal
    {
        public EfCargoCustomerDal(CargoContext context) : base(context)
        {

        }
    }
}