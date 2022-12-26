using CarInvoiceProblem;

namespace CarInvoiceProblemTest
{
    public class CabInvoiceTest
    {
        private CabInvoiceGenerator cabInvoiceGenerator;
        [SetUp]
        public void Setup()            //For creating instance of class
        {
            this.cabInvoiceGenerator = new CabInvoiceGenerator();
        }

        //[Test]
        ////Test to get total fare using given time and distance
        //public void GivenProperDistanceAndTimeForSingleRide_ShouldReturnTotalFare()
        //{
        //    double totalFare = cabInvoiceGenerator.CalculateFare(3.0, 5.0);
        //    Assert.AreEqual(35.0, totalFare);
        //}
        //[Test]
        ////Test to get Mininum Fare when given less than minimum fare
        //public void GivenProperDistanceAndTimeForSingleRide_LessThanMinFare_ShouldReturnMinimumFare()
        //{
        //    double CabFare = cabInvoiceGenerator.CalculateFare(0.1, 0.5);
        //    Assert.AreEqual(5, CabFare);
        //}
        ////[Test]
        //////Test to get aggregate fare for multiple rides
        ////public void GivenProperDistanceAndTimeForMultipleRide_ShouldReturnAggregateFare()
        ////{
        ////    Ride[] ride = { new Ride(3.0, 5.0), new Ride(2.0, 5.0), new Ride(0.1,0.5) };
        ////    double INVOICE_SUMMARY=this.cabInvoiceGenerator.GetMultipleRideFare(ride);
        ////    Assert.AreEqual(65, INVOICE_SUMMARY);
        ////}
        //[Test]
        ////Test to get aggregate fare and no of rides for multiple rides after refactor
        //public void GivenProperDistanceAndTimeForMultipleRide_ShouldReturnAggregateFare()
        //{
        //    Ride[] ride = { new Ride(4.0, 5.0), new Ride(2.0, 5.0), new Ride(0.1, 0.5) };
        //    EnhancedInvoiceSummary INVOICE_SUMMARY = this.cabInvoiceGenerator.GetMultipleRideFare(ride);
        //    Assert.AreEqual(75, INVOICE_SUMMARY.totalFare);
        //    Assert.AreEqual(3, INVOICE_SUMMARY.totalNumberOfRides);
        //    Assert.AreEqual(25, INVOICE_SUMMARY.averageFarePerRide);
        //}
        //[Test]
        ////Test  List of rides by giving userID
        //public void GivenUserIDInInvoice_GetsListofRides_ReturnAverageFareTotalFare()
        //{
        //    CabInvoiceGenerator repository = new CabInvoiceGenerator();
        //    Ride[] ride = { new Ride(4.0, 5.0), new Ride(2.0, 5.0), new Ride(0.1, 0.5) };
        //    Ride[] rideNew = { new Ride(6.0, 5.0), new Ride(4.0, 5.0) };
        //    repository.MapRidesToUser("shubham", ride);
        //    repository.MapRidesToUser("rahul", rideNew);
        //    EnhancedInvoiceSummary INVOICE_SUMMARY = repository.GetEnhancedInvoiceSummary("shubham");
        //    EnhancedInvoiceSummary INVOICE_SUMMARY_NEW = repository.GetEnhancedInvoiceSummary("rahul");
        //    Assert.AreEqual(75, INVOICE_SUMMARY.totalFare);
        //    Assert.AreEqual(25, INVOICE_SUMMARY.averageFarePerRide);
        //    Assert.AreEqual(3, INVOICE_SUMMARY.totalNumberOfRides);
        //    Assert.AreEqual(110, INVOICE_SUMMARY_NEW.totalFare);
        //    Assert.AreEqual(55, INVOICE_SUMMARY_NEW.averageFarePerRide);
        //    Assert.AreEqual(2, INVOICE_SUMMARY_NEW.totalNumberOfRides);
        //}
        [Test]
        //Test  For Normal and Premium Rides
        public void GivenRideOption_NormalOrPremium_ReturnInvoiceSummary()
        {
            CabInvoiceGenerator repository = new CabInvoiceGenerator();
            Ride[] ride = { new Ride(4.0, 5.0), new Ride(2.0, 5.0), new Ride(0.1, 0.5) };
            Ride[] rideNew = { new Ride(4.0, 5.0), new Ride(2.0, 5.0), new Ride(0.1, 0.5) };
            repository.MapRidesToUser("arush", ride);
            repository.MapRidesToUser("rohit", rideNew);
            EnhancedInvoiceSummary INVOICE_SUMMARY = repository.GetEnhancedInvoiceSummary(RideOption.RideTypes.NORMAL, "arush");
            EnhancedInvoiceSummary INVOICE_SUMMARY_NEW = repository.GetEnhancedInvoiceSummary(RideOption.RideTypes.PREMIUM, "rohit");
            Assert.AreEqual(75, INVOICE_SUMMARY.totalFare);
            Assert.AreEqual(25, INVOICE_SUMMARY.averageFarePerRide);
            Assert.AreEqual(3, INVOICE_SUMMARY.totalNumberOfRides);
            Assert.AreEqual(130, INVOICE_SUMMARY_NEW.totalFare);
            Assert.AreEqual(43.333333333333336d, INVOICE_SUMMARY_NEW.averageFarePerRide);
            Assert.AreEqual(3, INVOICE_SUMMARY_NEW.totalNumberOfRides);
        }
    }
}