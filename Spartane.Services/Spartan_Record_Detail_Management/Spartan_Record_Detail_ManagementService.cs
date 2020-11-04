using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Spartan_Record_Detail_Management;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Spartan_Record_Detail_Management
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Spartan_Record_Detail_ManagementService : ISpartan_Record_Detail_ManagementService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management> _Spartan_Record_Detail_ManagementRepository;
        #endregion

        #region Ctor
        public Spartan_Record_Detail_ManagementService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management> Spartan_Record_Detail_ManagementRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Spartan_Record_Detail_ManagementRepository = Spartan_Record_Detail_ManagementRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management> SelAll(bool ConRelaciones)
        {
            return this._Spartan_Record_Detail_ManagementRepository.Table.ToList();
        }

        public IList<Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management> SelAllComplete(bool ConRelaciones)
        {
            return this._Spartan_Record_Detail_ManagementRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Spartan_Record_Detail_ManagementRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Spartan_Record_Detail_ManagementRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Spartan_Record_Detail_ManagementRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_ManagementPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Spartan_Record_Detail_ManagementPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Spartan_Record_Detail_ManagementRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Spartan_Record_Detail_ManagementInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management entity, Spartane.Core.Domain.User.GlobalData Spartan_Record_Detail_ManagementInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management entity, Spartane.Core.Domain.User.GlobalData Spartan_Record_Detail_ManagementInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

