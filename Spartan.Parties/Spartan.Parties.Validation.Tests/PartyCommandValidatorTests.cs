using System;
using System.Threading.Tasks;

namespace Spartan.Parties.Validation.Tests
{
    class PartyCommandValidatorTests
    {
        public class PartyCommandValidator_Validate : NSpec.nspec
        {

        }
    }

    public abstract class BaseSpartanNspec : NSpec.nspec
    {
        public void GetMock<T>() where T : class
        {
        }
    }

    public abstract class SpartanNspec : BaseSpartanNspec
    {
        public override Action act => NonContextualAct;
        public override Action before => NonContextualBefore;

        protected virtual void NonContextualBefore() { }
        protected virtual void NonContextualAct() { }
    }

    public abstract class AsyncSpartanNSpec : BaseSpartanNspec
    {
        public override Func<Task> actAsync => async() => await NonContextualAct();
        public override Action before => NonContextualBefore;

        protected virtual Task NonContextualAct() => Task.CompletedTask;
        protected virtual void NonContextualBefore() { }
    }
}
