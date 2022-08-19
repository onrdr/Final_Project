using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;


ProductTest();

//CategoryTest();


Console.ReadKey();

static void ProductTest()
{
    ProductManager productManager = new(new EfProductDal()); 

    var result = productManager.GetProductDetails();
    if (result.Success)
    {
        Console.WriteLine(result.Message);
        result.Data.ForEach(p => Console.WriteLine($"{p.ProductName} - {p.CategoryName}"));
        return;
    }
    Console.WriteLine(result.Message);
}

static void CategoryTest()
{
    CategoryManager categoryManager = new(new EfCategoryDal());

    //categoryManager.GetAll().ForEach(c => Console.WriteLine(c.CategoryName));

    //var c = categoryManager.GetById(2);
    //Console.WriteLine($"{c.CategoryId}: {c.CategoryName}" ); 
}