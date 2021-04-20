using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Tipo_de_Localizacion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Tipo_de_Localizacion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Tipo_de_LocalizacionService : ITipo_de_LocalizacionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Tipo_de_Localizacion.Tipo_de_Localizacion> _Tipo_de_LocalizacionRepository;
        #endregion

        #region Ctor
        public Tipo_de_LocalizacionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Tipo_de_Localizacion.Tipo_de_Localizacion> Tipo_de_LocalizacionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Tipo_de_LocalizacionRepository = Tipo_de_LocalizacionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Tipo_de_Localizacion.Tipo_de_Localizacion> SelAll(bool ConRelaciones)
        {
            return this._Tipo_de_LocalizacionRepository.Table.ToList();
        }

        public IList<Core.Domain.Tipo_de_Localizacion.Tipo_de_Localizacion> SelAllComplete(bool ConRelaciones)
        {
            return this._Tipo_de_LocalizacionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Tipo_de_Localizacion.Tipo_de_Localizacion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_de_LocalizacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_de_Localizacion.Tipo_de_Localizacion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Tipo_de_LocalizacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_de_Localizacion.Tipo_de_Localizacion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_de_LocalizacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_de_Localizacion.Tipo_de_LocalizacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Tipo_de_LocalizacionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Tipo_de_Localizacion.Tipo_de_Localizacion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Tipo_de_LocalizacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_de_Localizacion.Tipo_de_Localizacion GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Tipo_de_Localizacion.Tipo_de_Localizacion result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Tipo_de_LocalizacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Tipo_de_Localizacion.Tipo_de_Localizacion entity, Spartane.Core.Domain.User.GlobalData Tipo_de_LocalizacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Tipo_de_Localizacion.Tipo_de_Localizacion entity, Spartane.Core.Domain.User.GlobalData Tipo_de_LocalizacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

