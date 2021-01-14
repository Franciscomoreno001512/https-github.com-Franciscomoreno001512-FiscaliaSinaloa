using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Generador_Solicitud_Denuncia_Ciudadana;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Generador_Solicitud_Denuncia_Ciudadana
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Generador_Solicitud_Denuncia_CiudadanaService : IGenerador_Solicitud_Denuncia_CiudadanaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Generador_Solicitud_Denuncia_Ciudadana.Generador_Solicitud_Denuncia_Ciudadana> _Generador_Solicitud_Denuncia_CiudadanaRepository;
        #endregion

        #region Ctor
        public Generador_Solicitud_Denuncia_CiudadanaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Generador_Solicitud_Denuncia_Ciudadana.Generador_Solicitud_Denuncia_Ciudadana> Generador_Solicitud_Denuncia_CiudadanaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Generador_Solicitud_Denuncia_CiudadanaRepository = Generador_Solicitud_Denuncia_CiudadanaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Generador_Solicitud_Denuncia_Ciudadana.Generador_Solicitud_Denuncia_Ciudadana> SelAll(bool ConRelaciones)
        {
            return this._Generador_Solicitud_Denuncia_CiudadanaRepository.Table.ToList();
        }

        public IList<Core.Domain.Generador_Solicitud_Denuncia_Ciudadana.Generador_Solicitud_Denuncia_Ciudadana> SelAllComplete(bool ConRelaciones)
        {
            return this._Generador_Solicitud_Denuncia_CiudadanaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Generador_Solicitud_Denuncia_Ciudadana.Generador_Solicitud_Denuncia_Ciudadana> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Generador_Solicitud_Denuncia_CiudadanaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Generador_Solicitud_Denuncia_Ciudadana.Generador_Solicitud_Denuncia_Ciudadana> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Generador_Solicitud_Denuncia_CiudadanaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Generador_Solicitud_Denuncia_Ciudadana.Generador_Solicitud_Denuncia_Ciudadana> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Generador_Solicitud_Denuncia_CiudadanaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Generador_Solicitud_Denuncia_Ciudadana.Generador_Solicitud_Denuncia_CiudadanaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Generador_Solicitud_Denuncia_CiudadanaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Generador_Solicitud_Denuncia_Ciudadana.Generador_Solicitud_Denuncia_Ciudadana> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Generador_Solicitud_Denuncia_CiudadanaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Generador_Solicitud_Denuncia_Ciudadana.Generador_Solicitud_Denuncia_Ciudadana GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Generador_Solicitud_Denuncia_Ciudadana.Generador_Solicitud_Denuncia_Ciudadana result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Generador_Solicitud_Denuncia_CiudadanaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Generador_Solicitud_Denuncia_Ciudadana.Generador_Solicitud_Denuncia_Ciudadana entity, Spartane.Core.Domain.User.GlobalData Generador_Solicitud_Denuncia_CiudadanaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Generador_Solicitud_Denuncia_Ciudadana.Generador_Solicitud_Denuncia_Ciudadana entity, Spartane.Core.Domain.User.GlobalData Generador_Solicitud_Denuncia_CiudadanaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

