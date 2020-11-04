using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Delito_Principal_MPI;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Delito_Principal_MPI
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Delito_Principal_MPIService : IDelito_Principal_MPIService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Delito_Principal_MPI.Delito_Principal_MPI> _Delito_Principal_MPIRepository;
        #endregion

        #region Ctor
        public Delito_Principal_MPIService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Delito_Principal_MPI.Delito_Principal_MPI> Delito_Principal_MPIRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Delito_Principal_MPIRepository = Delito_Principal_MPIRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Delito_Principal_MPI.Delito_Principal_MPI> SelAll(bool ConRelaciones)
        {
            return this._Delito_Principal_MPIRepository.Table.ToList();
        }

        public IList<Core.Domain.Delito_Principal_MPI.Delito_Principal_MPI> SelAllComplete(bool ConRelaciones)
        {
            return this._Delito_Principal_MPIRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Delito_Principal_MPI.Delito_Principal_MPI> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Delito_Principal_MPIRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Delito_Principal_MPI.Delito_Principal_MPI> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Delito_Principal_MPIRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Delito_Principal_MPI.Delito_Principal_MPI> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Delito_Principal_MPIRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Delito_Principal_MPI.Delito_Principal_MPIPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Delito_Principal_MPIPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Delito_Principal_MPI.Delito_Principal_MPI> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Delito_Principal_MPIRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Delito_Principal_MPI.Delito_Principal_MPI GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Delito_Principal_MPI.Delito_Principal_MPI result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Delito_Principal_MPIInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Delito_Principal_MPI.Delito_Principal_MPI entity, Spartane.Core.Domain.User.GlobalData Delito_Principal_MPIInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Delito_Principal_MPI.Delito_Principal_MPI entity, Spartane.Core.Domain.User.GlobalData Delito_Principal_MPIInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

