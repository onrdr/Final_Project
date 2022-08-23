using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;


ProductTest();

//CategoryTest();


Console.ReadKey();

static void ProductTest()
{
    ProductManager productManager = new(new EfProductDal(), new CategoryManager(new EfCategoryDal())); 

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
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll().Data)
    {
        Console.WriteLine(category.CategoryName);
    }
}