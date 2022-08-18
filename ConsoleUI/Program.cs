using Business.Concrete;
using DataAccess.Concrete.EntityFramework; 


ProductManager productManager = new(new EfProductDal());

//productManager.GetAll().ForEach(p => Console.WriteLine(p.ProductName));

//productManager.GetAllByCategoryId(2).ForEach(p => Console.WriteLine($"{p.CategoryId} - {p.ProductName}"));

//productManager.GetByUnitPrice(40, 100).ForEach(p => Console.WriteLine($"{p.ProductName} - {p.UnitPrice}"));


Console.ReadKey();