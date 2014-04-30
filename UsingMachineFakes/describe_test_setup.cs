using Machine.Specifications;
using Should;

// ReSharper disable ConvertToLambdaExpression
namespace ProvenStyle.UsingMachineFakes
{
    [Subject("Unit test")]
    public class when_setting_up_testing_environment
    {
        It should_run_tests = () => {true.ShouldBeTrue();};
    }
}
