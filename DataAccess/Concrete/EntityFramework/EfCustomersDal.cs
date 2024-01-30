using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;
internal class EfCustomersDal : ICustomersDal

{
 private readonly RentACarContext _context;

    public  EfCustomersDal(RentACarContext context) 
    {
        _context = context; 
    }

    public Customers  Add (Customers entity   )
    {
        _context.Entry(entity).State = EntityState.Added;


        _context.SaveChanges();

        return entity;  
    }

    public Customers Delete(Customers entity , bool isSoftDelete= true) { 
       entity.DeletedAt = DateTime.UtcNow;
    if (isSoftDelete) { }
        _context.Customerss.Remove(entity);
        _context.Entry(entity).State = EntityState.Modified;



        _context.SaveChanges();
        return entity;  


    }


    

    public Customers? Get(Func<Customers, bool> predicate) {

        _context.Customerss.FirsOrDefault(predicate);


        return Customers; 

    }
    




    }

public IList<Customers> GetList(Func<Customers, bool>? predicate = null) {

    IQueryable<Customers> query = _context..Set<Customers>();
    if (predicate != null) { }
    query = query.Where(predicate).AsQueryable();
    return query.ToList();     
}

    
        
      
    
    

    public Customers Update(Customers entity)
    {

    entity.UpdateAt = DateTime.UtcNow;
    _context.Customerss.Update(entity);
    _context.SaveChanges();
    return entity;  
    }

