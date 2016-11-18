namespace GestAcaLib.Persistence
{
    internal class EnrollmentDAOImp : IEnrollmentDAO
    {
        private GestAcaDAL gestAcaDAL;

        public EnrollmentDAOImp(GestAcaDAL gestAcaDAL)
        {
            this.gestAcaDAL = gestAcaDAL;
        }
    }
}