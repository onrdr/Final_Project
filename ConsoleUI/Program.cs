using Business.Concrete;
using DataAccess.Concrete.InMemory;


ProductManager productManager = new(new InMemoryProductDal());
productManager.GetAll().ForEach(p => Console.WriteLine(p.ProductName));


Console.ReadKey();