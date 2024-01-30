using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;
public class EfCorporateCustomerDal : ICorporateCustomerDal

{
 private readonly RentACarContext _context;

    public EfCorporateCustomerDal(RentACarContext context)
    {
        _context = context; 
    }

    public CorporateCustomer  Add (CorporateCustomer entity   )
    {
        _context.Entry(entity).State = EntityState.Added;


        _context.SaveChanges();

        return entity;  
    }

    public CorporateCustomer Delete(CorporateCustomer entity , bool isSoftDelete= true) { 
       entity.DeletedAt = DateTime.UtcNow;
    if (isSoftDelete) { }
        _context.CorporateCustomers.Remove(entity);
        _context.Entry(entity).State = EntityState.Modified;



        _context.SaveChanges();
        return entity;  


    }


    

    public CorporateCustomer? Get(Func<CorporateCustomer, bool> predicate) {

        _context.CorporateCustomers.FirsOrDefault(predicate);


        return CorporateCustomer; 

    }
    




    }

public IList<CorporateCustomer> GetList(Func<CorporateCustomer, bool>? predicate = null) {

    IQueryable<CorporateCustomer> query = _context..Set<CorporateCustomer>();
    if (predicate != null) { }
    query = query.Where(predicate).AsQueryable();
    return query.ToList();     
}

    
        
      
    
    

    public CorporateCustomer Update(CorporateCustomer entity)
    {

    entity.UpdateAt = DateTime.UtcNow;
    _context.CorporateCustomers.Update(entity);
    _context.SaveChanges();
    return entity;  
    }

