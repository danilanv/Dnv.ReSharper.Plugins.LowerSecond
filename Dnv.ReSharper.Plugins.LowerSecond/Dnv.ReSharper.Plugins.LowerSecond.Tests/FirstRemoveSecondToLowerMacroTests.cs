using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace Dnv.ReSharper.Plugins.LowerSecond.Tests
{
    [TestFixture]
    public class FirstRemoveSecondToLowerMacroTests
    {
        private FirstRemoveSecondToLowerMacro _target;
        private List<string> _agr;

        [SetUp]
        public void SetUp()
        {
            _target = new FirstRemoveSecondToLowerMacro();
            _agr = new List<string>();
        }

        [Test]
        public void EvaluateQuickResult_ZeroArgument()
        {
            //act
            var result = _target.EvaluateQuickResult(null, _agr);

            //assert
            Assert.That(string.IsNullOrEmpty(result), Is.True);
        }

        [Test]
        public void EvaluateQuickResult_OneArgumentOneChar()
        {
            //arrange
            _agr.Add("I");

            //act
            var result = _target.EvaluateQuickResult(null, _agr);

            //assert
            Assert.That(result, Is.EqualTo("i"));
        }

        [Test]
        public void EvaluateQuickResult_OneArgumentTwoChars()
        {
            //arrange
            _agr.Add("IM");

            //act
            var result = _target.EvaluateQuickResult(null, _agr);

            //assert
            Assert.That(result, Is.EqualTo("m"));
        }

        [Test]
        public void EvaluateQuickResult_OneArgumentMoreThenTwoChars()
        {
            //arrange
            _agr.Add("IBo");

            //act
            var result = _target.EvaluateQuickResult(null, _agr);

            //assert
            Assert.That(result, Is.EqualTo("bo"));
        }

        [Test]
        public void EvaluateQuickResult_MoreThenOneArguments_EmptyString()
        {
            //arrange
            _agr.Add("IBo");
            _agr.Add("Noko");

            //act
            var result = _target.EvaluateQuickResult(null, _agr);

            //assert
            Assert.That(string.IsNullOrEmpty(result), Is.True);
        }
    }
}