namespace OfficeClient.Test

{
    [TestClass]
    public class ValidateFieldsTests
    {
        
        //nem sikerült referenciaként megadni a teszteli kívánt osztályt
        [TestMethod]
        public void ValidateName_Test_IsFalse()
        {
            var validatfields = new ValidateFields();
                
            var validatename = validatfields.ValidateName("Kiss László9");

            Assert.IsFalse(validatename);
        }

        [TestMethod]
        public void ValidatePlateNumber_Test_IsFalse()
        {
            var validatfields = new ValidateFields();

            var validateplatenumber1 = validatfields.ValidatePlateNumber("DASDFASDF");
            var validateplatenumber2 = validatfields.ValidatePlateNumber("DA-345");
            var validateplatenumber3 = validatfields.ValidatePlateNumber("DAdd-345");
            var validateplatenumber4 = validatfields.ValidatePlateNumber("DAd-f34");
            var validateplatenumber5 = validatfields.ValidatePlateNumber("DAD-3f5");

            Assert.IsFalse(validatename1);
            Assert.IsFalse(validatename2);
            Assert.IsFalse(validatename3);
            Assert.IsFalse(validatename4);
            Assert.IsFalse(validatename5);
        }
    }
}
