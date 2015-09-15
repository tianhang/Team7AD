using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryBL.EntityFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL.Entities;
using ClassLibraryBL;
namespace UnitTestFacade
{
    [TestClass]
    public class UnitTestFacade
    {
        //For testing ViewPendingFormFacade to check whether the value has been passed from front to facade and go back correctly
        ViewPendingFormFacade vpfFacade = new ViewPendingFormFacade();


        [TestMethod]
        public void ViewPendingFormFacade()
        {
            Object o = vpfFacade.getAllPendingItems();
            Assert.IsNotNull(o);

        }


        [TestMethod]
        public void getListByDept()
        {
            String selectedValue = "English Dept";
            Object o = vpfFacade.getListByDept(selectedValue);
            Assert.IsNotNull(o);
        }

        [TestMethod]
        public void getListByDeptDetail()
        {
            int i = 107;
            Object o = vpfFacade.getListByDeptDetail(i.ToString());
            Assert.IsNotNull(o);

        }


        //For testing UserFacade to check whether the value has been passed from front to facade and go back correctly
        UserFacade userFacade = new UserFacade();

        [TestMethod]
        public void delegateAuthority()
        {
            String uid = "u002";
            userFacade.delegateAuthority(uid);
        }

        [TestMethod]
        public void AssignNewRep()
        {
            String uid = "u002";
            userFacade.AssignNewRep(uid);
        }


        //For testing TrendForSupplierFacade to check whether the value has been passed from front to facade and go back correctly
        TrendForSupplierFacade tfsFacade = new TrendForSupplierFacade();

        [TestMethod]
        public void GetPrice()
        {
            string department="English Dept";
            string category="Notebook";
            int month = 10;
            Object o= tfsFacade.GetPrice(department, category, month);
            Assert.IsNotNull(o);
        }

        [TestMethod]
        public void getUnit()
        {
            string category = "Notebook";
            tfsFacade.getUnit(category);
        }

        //For testing SupplierFacade to check whether the value has been passed from front to facade and go back correctly

        SupplierFacade supplierFacade = new SupplierFacade();
        [TestMethod]
        public void checksupplierList()
        {
             List<supplier> l= supplierFacade.checksupplierList();
             Assert.IsNotNull(l);

        }
        [TestMethod]
        public void deletesupplier()
        {
            supplierFacade.deletesupplier(2070);
            // exception in this stage
        }

        public void searchbydescription()
        {
            supplierFacade.searchbydescription("Notebook", 2070);
        }

        [TestMethod]
        public void showitems()
        {
            List<SupplieritemMix> l = supplierFacade.showitems(2070);
            Assert.IsNotNull(l);
        }
        
        [TestMethod]
        public void editprice()
        {
            supplierFacade.editprice(1, 2070, 80);
        }

        [TestMethod]
        public void findSupplier()
        {
           supplier s=  supplierFacade.findsupplier(2084);
           Assert.IsNotNull(s);
        }

         [TestMethod]
        public void showsingleitem()
        {
            SupplieritemMix sm = supplierFacade.showsingleitem(1, 2000);
            Assert.IsNotNull(sm);
        }


        //For testing RequisitionTrendFacade to check whether the value has been passed from front to facade and go back correctly
         RequisitionTrendFacade rtFacede = new RequisitionTrendFacade();
         [TestMethod]
         public void GetCategoryName()
         {
            List<string> l= rtFacede.GetCategoryName();
            Assert.IsNotNull(l);
         }

         //For testing RequisitionFacade to check whether the value has been passed from front to facade and go back correctly
         RequisiitonFacade rFacade = new RequisiitonFacade();
         [TestMethod]
         public void getRequisitionDetails()
         {
            String rid = "60";
            List<RequisitionDetails> l=  rFacade.getRequisitionDetails(rid);
            Assert.IsNotNull(l);
         }



    }
}
