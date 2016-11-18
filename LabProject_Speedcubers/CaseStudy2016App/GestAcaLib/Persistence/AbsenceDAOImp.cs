namespace GestAcaLib.Persistence
{
    internal class AbsenceDAOImp : IAbsenceDAO
    {
        private GestAcaDAL gestAcaDAL;

        public AbsenceDAOImp(GestAcaDAL gestAcaDAL)
        {
            this.gestAcaDAL = gestAcaDAL;
        }
    }
}