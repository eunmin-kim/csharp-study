using System;

namespace delegateAndEvents
{
    public class MessageEventArgs : EventArgs
    {
        public string Message { get; }

        public MessageEventArgs(string message)
        {
            Message = message;
        }
    }

    public class Publisher
    {
        public event EventHandler<MessageEventArgs> MessagePublished;

        public void PublishMessage(string message)
        {
            MessagePublished?.Invoke(this, new MessageEventArgs(message));
        }
    }

    public class Subscriber
    {
        public void Subscribe(Publisher publisher)
        {
            publisher.MessagePublished += OnMessagePublished;
        }

        private void OnMessagePublished(object sender,  MessageEventArgs e)
        {
            Console.WriteLine($"Message received: {e.Message}");
        }
    }
    
    
    
    
    /// <summary>
    /// 델리게이트는 C#에서 함수 포인터와 유사한 개념입니다. 하지만 C나 C++의 함수 포인터보다 타입 안전성과 보안 측면에서 향상된 기능을 제공합니다. 델리게이트를 사용하여 메소드를 다른 메소드의 인자로 전달하거나, 메소드를 변수에 할당하는 것이 가능합니다. 델리게이트는 특정 메소드의 시그니처(반환 유형과 매개 변수 목록)와 일치하는 모든 메소드를 참조할 수 있습니다.
    /// </summary>
    public delegate void DisplayMessage(string message);
    internal class Program
    {
        public static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        public static void Main(string[] args)
        {
            /**
             * Delegate 예제
             */
            DisplayMessage displayMessage = ShowMessage;
            displayMessage("Hello, Delegate!");
            
            /**
             * Events 예제
             */

            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();
            subscriber.Subscribe(publisher);
            
            publisher.PublishMessage("Hello, Events!");
        }
    }
}