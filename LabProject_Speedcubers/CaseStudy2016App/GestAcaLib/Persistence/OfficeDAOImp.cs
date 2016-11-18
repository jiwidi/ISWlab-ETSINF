namespace GestAcaLib.Persistence
{
    internal class OfficeDAOImp : IOfficeDAO
    {
        private GestAcaDAL gestAcaDAL;

        public OfficeDAOImp(GestAcaDAL gestAcaDAL)
        {
            this.gestAcaDAL = gestAcaDAL;
        }
    }
}