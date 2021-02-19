using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Generador_Folio_Documentos_AT;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Generador_Folio_Documentos_AT
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Generador_Folio_Documentos_ATService : IGenerador_Folio_Documentos_ATService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT> _Generador_Folio_Documentos_ATRepository;
        #endregion

        #region Ctor
        public Generador_Folio_Documentos_ATService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT> Generador_Folio_Documentos_ATRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Generador_Folio_Documentos_ATRepository = Generador_Folio_Documentos_ATRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT> SelAll(bool ConRelaciones)
        {
            return this._Generador_Folio_Documentos_ATRepository.Table.ToList();
        }

        public IList<Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT> SelAllComplete(bool ConRelaciones)
        {
            return this._Generador_Folio_Documentos_ATRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Generador_Folio_Documentos_ATRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Generador_Folio_Documentos_ATRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Generador_Folio_Documentos_ATRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_ATPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Generador_Folio_Documentos_ATPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Generador_Folio_Documentos_ATRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Generador_Folio_Documentos_ATInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT entity, Spartane.Core.Domain.User.GlobalData Generador_Folio_Documentos_ATInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT entity, Spartane.Core.Domain.User.GlobalData Generador_Folio_Documentos_ATInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

