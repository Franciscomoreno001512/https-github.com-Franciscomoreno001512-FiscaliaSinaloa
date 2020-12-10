using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Modulo_Encuesta;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Modulo_Encuesta
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Modulo_EncuestaService : IModulo_EncuestaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Modulo_Encuesta.Modulo_Encuesta> _Modulo_EncuestaRepository;
        #endregion

        #region Ctor
        public Modulo_EncuestaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Modulo_Encuesta.Modulo_Encuesta> Modulo_EncuestaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Modulo_EncuestaRepository = Modulo_EncuestaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Modulo_Encuesta.Modulo_Encuesta> SelAll(bool ConRelaciones)
        {
            return this._Modulo_EncuestaRepository.Table.ToList();
        }

        public IList<Core.Domain.Modulo_Encuesta.Modulo_Encuesta> SelAllComplete(bool ConRelaciones)
        {
            return this._Modulo_EncuestaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Modulo_Encuesta.Modulo_Encuesta> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Modulo_EncuestaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Modulo_Encuesta.Modulo_Encuesta> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Modulo_EncuestaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Modulo_Encuesta.Modulo_Encuesta> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Modulo_EncuestaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Modulo_Encuesta.Modulo_EncuestaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Modulo_EncuestaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Modulo_Encuesta.Modulo_Encuesta> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Modulo_EncuestaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Modulo_Encuesta.Modulo_Encuesta GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Modulo_Encuesta.Modulo_Encuesta result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Modulo_EncuestaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Modulo_Encuesta.Modulo_Encuesta entity, Spartane.Core.Domain.User.GlobalData Modulo_EncuestaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Modulo_Encuesta.Modulo_Encuesta entity, Spartane.Core.Domain.User.GlobalData Modulo_EncuestaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

