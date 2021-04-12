using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lesson10.Models;
using Microsoft.Data.SqlClient;

namespace Lesson10.Data
{
    public class CustomerController : Controller
    {
        private readonly BookContext dataContext;

        public CustomerController(BookContext context)
        {
            dataContext = context;
        }


        public IActionResult SelectWithSQL() {

            // Each row returned is a Customer		
            List<Customer> customers = dataContext.Customers.FromSqlRaw("select * from Customer").ToList();
            return View("Index", customers);
        }

        public IActionResult SelectWithSqlAndLinq()
        {

            // Each row returned is a Customer		
            List<Customer> customers = dataContext.Customers
                .FromSqlRaw("select * from Customer")
                .Where(c => c.Zip == "8000")
                .ToList();
            return View("Index", customers);
        }

        public ActionResult SelectFromView()
        // dataContext is the context class
        {
            // Each row returned is a Customer		List<Customer> customers =
            List<Customer> customers = dataContext.Customers.FromSqlRaw<Customer>(
            "select * from CustomersView").ToList();
            return View("Index", customers);
        }

        public ActionResult SelectFromSp()
        {
            // dataContext is the context class 			
            SqlParameter zip = new SqlParameter("@Zip", "8000");

            List<Customer> customers = dataContext.Customers.FromSqlRaw<Customer>("exec CustomersByZip @Zip", zip).ToList();

            return View("Index", customers);
        }

        public ActionResult InsertCustomer()
        {

            dataContext.Database.ExecuteSqlRaw("Insert Into Customer (Name, Address, City, Zip) Values ('Tommy Andersen', 'Havvej 4', 'Aarhus', '8000')");

            return View("Index", dataContext.Customers.ToList());
        }


        public ActionResult InsertCustomerSp()
        {
            dataContext.Database.ExecuteSqlRaw("exec CreateCustomer @p0, @p1, @p2, @p3", parameters: new[] { "Tina Andersson", "Mågevej 124", "Malling", "8340" });

            return View("Index", dataContext.Customers.ToList());
        }



        // GET: Customer
        public async Task<IActionResult> Index()
        {
            return View(await dataContext.Customers.ToListAsync());
        }

        // GET: Customer/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await dataContext.Customers
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customer/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,Name,Address,City,Zip")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                dataContext.Add(customer);
                await dataContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customer/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await dataContext.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Customer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,Name,Address,City,Zip")] Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    dataContext.Update(customer);
                    await dataContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.CustomerId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customer/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await dataContext.Customers
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await dataContext.Customers.FindAsync(id);
            dataContext.Customers.Remove(customer);
            await dataContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return dataContext.Customers.Any(e => e.CustomerId == id);
        }
    }
}
