using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Solicitante_MPI;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Solicitante_MPI
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Solicitante_MPIService : ISolicitante_MPIService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Solicitante_MPI.Solicitante_MPI> _Solicitante_MPIRepository;
        #endregion

        #region Ctor
        public Solicitante_MPIService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Solicitante_MPI.Solicitante_MPI> Solicitante_MPIRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Solicitante_MPIRepository = Solicitante_MPIRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Solicitante_MPI.Solicitante_MPI> SelAll(bool ConRelaciones)
        {
            return this._Solicitante_MPIRepository.Table.ToList();
        }

        public IList<Core.Domain.Solicitante_MPI.Solicitante_MPI> SelAllComplete(bool ConRelaciones)
        {
            return this._Solicitante_MPIRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Solicitante_MPI.Solicitante_MPI> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Solicitante_MPIRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Solicitante_MPI.Solicitante_MPI> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Solicitante_MPIRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Solicitante_MPI.Solicitante_MPI> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Solicitante_MPIRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Solicitante_MPI.Solicitante_MPIPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Solicitante_MPIPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Solicitante_MPI.Solicitante_MPI> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Solicitante_MPIRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Solicitante_MPI.Solicitante_MPI GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Solicitante_MPI.Solicitante_MPI result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Solicitante_MPIInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Solicitante_MPI.Solicitante_MPI entity, Spartane.Core.Domain.User.GlobalData Solicitante_MPIInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Solicitante_MPI.Solicitante_MPI entity, Spartane.Core.Domain.User.GlobalData Solicitante_MPIInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

