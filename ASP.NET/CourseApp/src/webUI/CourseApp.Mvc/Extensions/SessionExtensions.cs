using System.Text.Json;

namespace CourseApp.Mvc.Extensions
{
    public static class SessionExtensions
    {
        public static void SetJson<T>(this ISession session, string key, T value)
        {
            var serialized = JsonSerializer.Serialize<T>(value);
            session.SetString(key, serialized);
        }
        public static T GetJson<T>(this ISession session, string key)
        {
            var serializedString = session.GetString(key);

            return serializedString == null ? default(T) :
                                               JsonSerializer.Deserialize<T>(serializedString);


        }
    }
}
