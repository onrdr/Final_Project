using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;


ProductTest();

//CategoryTest();


Console.ReadKey();

static void ProductTest()
{
    ProductManager productManager = new(new EfProductDal());

    //productManager.GetAll().ForEach(p => Console.WriteLine(p.ProductName));

    //productManager.GetAllByCategoryId(2).ForEach(p => Console.WriteLine($"{p.CategoryId} - {p.ProductName}"));

    //productManager.GetByUnitPrice(40, 100).ForEach(p => Console.WriteLine($"{p.ProductName} - {p.UnitPrice}"));

    //productManager.GetProductDetails().ForEach(p => Console.WriteLine($"{p.ProductName} - {p.CategoryName}"));
}

static void CategoryTest()
{
    CategoryManager categoryManager = new(new EfCategoryDal());

    //categoryManager.GetAll().ForEach(c => Console.WriteLine(c.CategoryName));

    //var c = categoryManager.GetById(2);
    //Console.WriteLine($"{c.CategoryId}: {c.CategoryName}" ); 
}