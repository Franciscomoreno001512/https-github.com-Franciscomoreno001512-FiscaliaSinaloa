using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Respuesta;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Respuesta
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class RespuestaService : IRespuestaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Respuesta.Respuesta> _RespuestaRepository;
        #endregion

        #region Ctor
        public RespuestaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Respuesta.Respuesta> RespuestaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._RespuestaRepository = RespuestaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Respuesta.Respuesta> SelAll(bool ConRelaciones)
        {
            return this._RespuestaRepository.Table.ToList();
        }

        public IList<Core.Domain.Respuesta.Respuesta> SelAllComplete(bool ConRelaciones)
        {
            return this._RespuestaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Respuesta.Respuesta> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._RespuestaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Respuesta.Respuesta> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._RespuestaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Respuesta.Respuesta> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._RespuestaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Respuesta.RespuestaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            RespuestaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Respuesta.Respuesta> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._RespuestaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Respuesta.Respuesta GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Respuesta.Respuesta result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData RespuestaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Respuesta.Respuesta entity, Spartane.Core.Domain.User.GlobalData RespuestaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Respuesta.Respuesta entity, Spartane.Core.Domain.User.GlobalData RespuestaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

