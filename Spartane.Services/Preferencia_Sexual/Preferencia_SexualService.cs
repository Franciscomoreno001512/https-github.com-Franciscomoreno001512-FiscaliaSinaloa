using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Preferencia_Sexual;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Preferencia_Sexual
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Preferencia_SexualService : IPreferencia_SexualService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Preferencia_Sexual.Preferencia_Sexual> _Preferencia_SexualRepository;
        #endregion

        #region Ctor
        public Preferencia_SexualService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Preferencia_Sexual.Preferencia_Sexual> Preferencia_SexualRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Preferencia_SexualRepository = Preferencia_SexualRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Preferencia_Sexual.Preferencia_Sexual> SelAll(bool ConRelaciones)
        {
            return this._Preferencia_SexualRepository.Table.ToList();
        }

        public IList<Core.Domain.Preferencia_Sexual.Preferencia_Sexual> SelAllComplete(bool ConRelaciones)
        {
            return this._Preferencia_SexualRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Preferencia_Sexual.Preferencia_Sexual> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Preferencia_SexualRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Preferencia_Sexual.Preferencia_Sexual> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Preferencia_SexualRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Preferencia_Sexual.Preferencia_Sexual> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Preferencia_SexualRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Preferencia_Sexual.Preferencia_SexualPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Preferencia_SexualPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Preferencia_Sexual.Preferencia_Sexual> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Preferencia_SexualRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Preferencia_Sexual.Preferencia_Sexual GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Preferencia_Sexual.Preferencia_Sexual result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Preferencia_SexualInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Preferencia_Sexual.Preferencia_Sexual entity, Spartane.Core.Domain.User.GlobalData Preferencia_SexualInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Preferencia_Sexual.Preferencia_Sexual entity, Spartane.Core.Domain.User.GlobalData Preferencia_SexualInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

