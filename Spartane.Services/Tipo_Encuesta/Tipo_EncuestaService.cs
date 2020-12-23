using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Tipo_Encuesta;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Tipo_Encuesta
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Tipo_EncuestaService : ITipo_EncuestaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Tipo_Encuesta.Tipo_Encuesta> _Tipo_EncuestaRepository;
        #endregion

        #region Ctor
        public Tipo_EncuestaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Tipo_Encuesta.Tipo_Encuesta> Tipo_EncuestaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Tipo_EncuestaRepository = Tipo_EncuestaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Tipo_Encuesta.Tipo_Encuesta> SelAll(bool ConRelaciones)
        {
            return this._Tipo_EncuestaRepository.Table.ToList();
        }

        public IList<Core.Domain.Tipo_Encuesta.Tipo_Encuesta> SelAllComplete(bool ConRelaciones)
        {
            return this._Tipo_EncuestaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Tipo_Encuesta.Tipo_Encuesta> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_EncuestaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_Encuesta.Tipo_Encuesta> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Tipo_EncuestaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_Encuesta.Tipo_Encuesta> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_EncuestaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_Encuesta.Tipo_EncuestaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Tipo_EncuestaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Tipo_Encuesta.Tipo_Encuesta> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Tipo_EncuestaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_Encuesta.Tipo_Encuesta GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Tipo_Encuesta.Tipo_Encuesta result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Tipo_EncuestaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Tipo_Encuesta.Tipo_Encuesta entity, Spartane.Core.Domain.User.GlobalData Tipo_EncuestaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Tipo_Encuesta.Tipo_Encuesta entity, Spartane.Core.Domain.User.GlobalData Tipo_EncuestaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

