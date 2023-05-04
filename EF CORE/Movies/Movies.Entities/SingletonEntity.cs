namespace Movies.Entities
{
    public class SingletonEntity : IEntity
    {
        private static SingletonEntity _entity = null;
        private SingletonEntity()
        {

        }

        public static SingletonEntity CreateInstance()
        {
            if (_entity == null)
            {
                _entity = new SingletonEntity();
            }
            return _entity;
        }



    }
}
