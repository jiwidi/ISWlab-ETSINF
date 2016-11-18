namespace GestAcaLib.Persistence
{
    internal class PersonDAOImp : IPersonDAO
    {
        private GestAcaDAL gestAcaDAL;

        public PersonDAOImp(GestAcaDAL gestAcaDAL)
        {
            this.gestAcaDAL = gestAcaDAL;
        }
    }
}