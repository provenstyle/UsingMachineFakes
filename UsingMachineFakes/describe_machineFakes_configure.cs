using Machine.Fakes;
using Machine.Specifications;
using Should;

// ReSharper disable ConvertToLambdaExpression
// ReSharper disable InconsistentNaming
namespace ProvenStyle.UsingMachineFakes
{
    [Subject("Machine Fakes")]
    public class when_using_configure : WithSubject<MessageService>
    {
        Establish context = () =>
        {
            Configure<IMessageService>(new TestMessageService());
        };

        Because of = () =>
        {
            _message = Subject.GetMessage();
        };

        It should_create_instance_of_my_subject_under_test = () =>
        {
            Subject.ShouldNotBeNull();
        };

        It should_allow_me_to_mock_properties_on_dependencies = () =>
        {
            _message.ShouldEqual("Test Implementation");
        };

        private static string _message;
    }

    public class TestMessageService : IMessageService
    {
        public string Message { get { return "Test Implementation"; } }
    }
}
