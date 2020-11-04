using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Catalogo_Respuesta;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Catalogo_Respuesta
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Catalogo_RespuestaService : ICatalogo_RespuestaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta> _Catalogo_RespuestaRepository;
        #endregion

        #region Ctor
        public Catalogo_RespuestaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta> Catalogo_RespuestaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Catalogo_RespuestaRepository = Catalogo_RespuestaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta> SelAll(bool ConRelaciones)
        {
            return this._Catalogo_RespuestaRepository.Table.ToList();
        }

        public IList<Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta> SelAllComplete(bool ConRelaciones)
        {
            return this._Catalogo_RespuestaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Catalogo_RespuestaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Catalogo_RespuestaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Catalogo_RespuestaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_RespuestaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Catalogo_RespuestaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Catalogo_RespuestaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Catalogo_RespuestaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta entity, Spartane.Core.Domain.User.GlobalData Catalogo_RespuestaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta entity, Spartane.Core.Domain.User.GlobalData Catalogo_RespuestaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

