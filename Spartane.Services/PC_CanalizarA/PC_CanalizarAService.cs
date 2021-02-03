using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.PC_CanalizarA;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.PC_CanalizarA
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class PC_CanalizarAService : IPC_CanalizarAService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA> _PC_CanalizarARepository;
        #endregion

        #region Ctor
        public PC_CanalizarAService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA> PC_CanalizarARepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._PC_CanalizarARepository = PC_CanalizarARepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA> SelAll(bool ConRelaciones)
        {
            return this._PC_CanalizarARepository.Table.ToList();
        }

        public IList<Core.Domain.PC_CanalizarA.PC_CanalizarA> SelAllComplete(bool ConRelaciones)
        {
            return this._PC_CanalizarARepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._PC_CanalizarARepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._PC_CanalizarARepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._PC_CanalizarARepository.Table.ToList();
        }

        public Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarAPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            PC_CanalizarAPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._PC_CanalizarARepository.Table.ToList();
        }

        public Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData PC_CanalizarAInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA entity, Spartane.Core.Domain.User.GlobalData PC_CanalizarAInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA entity, Spartane.Core.Domain.User.GlobalData PC_CanalizarAInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

