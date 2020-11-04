using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Requerido_MPI;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Requerido_MPI
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Requerido_MPIService : IRequerido_MPIService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Requerido_MPI.Requerido_MPI> _Requerido_MPIRepository;
        #endregion

        #region Ctor
        public Requerido_MPIService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Requerido_MPI.Requerido_MPI> Requerido_MPIRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Requerido_MPIRepository = Requerido_MPIRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Requerido_MPI.Requerido_MPI> SelAll(bool ConRelaciones)
        {
            return this._Requerido_MPIRepository.Table.ToList();
        }

        public IList<Core.Domain.Requerido_MPI.Requerido_MPI> SelAllComplete(bool ConRelaciones)
        {
            return this._Requerido_MPIRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Requerido_MPI.Requerido_MPI> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Requerido_MPIRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Requerido_MPI.Requerido_MPI> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Requerido_MPIRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Requerido_MPI.Requerido_MPI> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Requerido_MPIRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Requerido_MPI.Requerido_MPIPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Requerido_MPIPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Requerido_MPI.Requerido_MPI> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Requerido_MPIRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Requerido_MPI.Requerido_MPI GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Requerido_MPI.Requerido_MPI result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Requerido_MPIInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Requerido_MPI.Requerido_MPI entity, Spartane.Core.Domain.User.GlobalData Requerido_MPIInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Requerido_MPI.Requerido_MPI entity, Spartane.Core.Domain.User.GlobalData Requerido_MPIInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

