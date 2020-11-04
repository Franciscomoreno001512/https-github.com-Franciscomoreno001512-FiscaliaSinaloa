using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Catalogo_de_Estatus_de_Folio
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Catalogo_de_Estatus_de_FolioService : ICatalogo_de_Estatus_de_FolioService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio> _Catalogo_de_Estatus_de_FolioRepository;
        #endregion

        #region Ctor
        public Catalogo_de_Estatus_de_FolioService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio> Catalogo_de_Estatus_de_FolioRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Catalogo_de_Estatus_de_FolioRepository = Catalogo_de_Estatus_de_FolioRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio> SelAll(bool ConRelaciones)
        {
            return this._Catalogo_de_Estatus_de_FolioRepository.Table.ToList();
        }

        public IList<Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio> SelAllComplete(bool ConRelaciones)
        {
            return this._Catalogo_de_Estatus_de_FolioRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Catalogo_de_Estatus_de_FolioRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Catalogo_de_Estatus_de_FolioRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Catalogo_de_Estatus_de_FolioRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_FolioPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Catalogo_de_Estatus_de_FolioPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Catalogo_de_Estatus_de_FolioRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Catalogo_de_Estatus_de_FolioInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio entity, Spartane.Core.Domain.User.GlobalData Catalogo_de_Estatus_de_FolioInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio entity, Spartane.Core.Domain.User.GlobalData Catalogo_de_Estatus_de_FolioInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

