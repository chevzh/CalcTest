using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestCalc
{
    public class Test
    {

        [Test]
        public void Sum_2Plus5_7Returned()
        {
            // act
            var res = Calc.Class1.Sum(2, 5);

            // assert
            Assert.AreEqual(7, res);
        }

        [Test]
        public void Sum_1()
        {


            // act
            var res = Calc.Class1.Sum(-30, 5);

            // assert
            Assert.AreEqual(-25, res);
        }

        [Test]
        public void Sum_2()
        {
            
            // act
            var res = Calc.Class1.Sum(-30, -5);

            // assert
            Assert.AreEqual(-35, res);
        }

        [Test]
        public void Mul_0()
        {

            // act
            var res = Calc.Class1.Mul(0, 4);

            // assert
            Assert.AreEqual(0, res);
        }

        [Test]
        public void Mul_Min()
        {

            // act
            var res = Calc.Class1.Mul(-1, 4);

            // assert
            Assert.AreEqual(-4, res);
        }

        [Test]
        public void Mul_1()
        {

            // act
            var res = Calc.Class1.Mul(1, 4);

            // assert
            Assert.AreEqual(4, res);
        }

        [Test]
        public void Div_Min()
        {
            // act
            var res = Calc.Class1.Div(-25, 5);

            // assert
            Assert.AreEqual(-5, res);
        }

        [Test]
        public void Div_0()
        {
            // act
            var res = Calc.Class1.Div(0, 5);

            // assert
            Assert.AreEqual(0, res);
        }
        [Test]
        public void Div_1()
        {
            // act
            var res = Calc.Class1.Div(25, 5);

            // assert
            Assert.AreEqual(5, res);
        }

        [Test]
        public void Res_Min()
        {

            // act
            var res = Calc.Class1.Res(-1, 3);

            // assert
            Assert.AreEqual(-4, res);
        }

        [Test]
        public void Res_Fail()
        {

            // act
            var res = Calc.Class1.Res(3, -3);

            // assert
            Assert.AreEqual(0, res);
        }

        [Test]
        public void Res_Plus()
        {

            // act
            var res = Calc.Class1.Res(-1, -3);

            // assert
            Assert.AreEqual(2, res);
        }


    }
}
