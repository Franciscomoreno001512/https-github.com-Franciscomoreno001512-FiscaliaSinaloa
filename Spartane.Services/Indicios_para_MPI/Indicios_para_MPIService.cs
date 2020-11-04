using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Indicios_para_MPI;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Indicios_para_MPI
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Indicios_para_MPIService : IIndicios_para_MPIService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Indicios_para_MPI.Indicios_para_MPI> _Indicios_para_MPIRepository;
        #endregion

        #region Ctor
        public Indicios_para_MPIService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Indicios_para_MPI.Indicios_para_MPI> Indicios_para_MPIRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Indicios_para_MPIRepository = Indicios_para_MPIRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Indicios_para_MPI.Indicios_para_MPI> SelAll(bool ConRelaciones)
        {
            return this._Indicios_para_MPIRepository.Table.ToList();
        }

        public IList<Core.Domain.Indicios_para_MPI.Indicios_para_MPI> SelAllComplete(bool ConRelaciones)
        {
            return this._Indicios_para_MPIRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Indicios_para_MPI.Indicios_para_MPI> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Indicios_para_MPIRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Indicios_para_MPI.Indicios_para_MPI> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Indicios_para_MPIRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Indicios_para_MPI.Indicios_para_MPI> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Indicios_para_MPIRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Indicios_para_MPI.Indicios_para_MPIPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Indicios_para_MPIPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Indicios_para_MPI.Indicios_para_MPI> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Indicios_para_MPIRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Indicios_para_MPI.Indicios_para_MPI GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Indicios_para_MPI.Indicios_para_MPI result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Indicios_para_MPIInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Indicios_para_MPI.Indicios_para_MPI entity, Spartane.Core.Domain.User.GlobalData Indicios_para_MPIInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Indicios_para_MPI.Indicios_para_MPI entity, Spartane.Core.Domain.User.GlobalData Indicios_para_MPIInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

