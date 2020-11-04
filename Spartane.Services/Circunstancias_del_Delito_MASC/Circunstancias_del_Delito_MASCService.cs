using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Circunstancias_del_Delito_MASC;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Circunstancias_del_Delito_MASC
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Circunstancias_del_Delito_MASCService : ICircunstancias_del_Delito_MASCService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Circunstancias_del_Delito_MASC.Circunstancias_del_Delito_MASC> _Circunstancias_del_Delito_MASCRepository;
        #endregion

        #region Ctor
        public Circunstancias_del_Delito_MASCService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Circunstancias_del_Delito_MASC.Circunstancias_del_Delito_MASC> Circunstancias_del_Delito_MASCRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Circunstancias_del_Delito_MASCRepository = Circunstancias_del_Delito_MASCRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Circunstancias_del_Delito_MASC.Circunstancias_del_Delito_MASC> SelAll(bool ConRelaciones)
        {
            return this._Circunstancias_del_Delito_MASCRepository.Table.ToList();
        }

        public IList<Core.Domain.Circunstancias_del_Delito_MASC.Circunstancias_del_Delito_MASC> SelAllComplete(bool ConRelaciones)
        {
            return this._Circunstancias_del_Delito_MASCRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Circunstancias_del_Delito_MASC.Circunstancias_del_Delito_MASC> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Circunstancias_del_Delito_MASCRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Circunstancias_del_Delito_MASC.Circunstancias_del_Delito_MASC> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Circunstancias_del_Delito_MASCRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Circunstancias_del_Delito_MASC.Circunstancias_del_Delito_MASC> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Circunstancias_del_Delito_MASCRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Circunstancias_del_Delito_MASC.Circunstancias_del_Delito_MASCPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Circunstancias_del_Delito_MASCPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Circunstancias_del_Delito_MASC.Circunstancias_del_Delito_MASC> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Circunstancias_del_Delito_MASCRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Circunstancias_del_Delito_MASC.Circunstancias_del_Delito_MASC GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Circunstancias_del_Delito_MASC.Circunstancias_del_Delito_MASC result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Circunstancias_del_Delito_MASCInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Circunstancias_del_Delito_MASC.Circunstancias_del_Delito_MASC entity, Spartane.Core.Domain.User.GlobalData Circunstancias_del_Delito_MASCInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Circunstancias_del_Delito_MASC.Circunstancias_del_Delito_MASC entity, Spartane.Core.Domain.User.GlobalData Circunstancias_del_Delito_MASCInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

