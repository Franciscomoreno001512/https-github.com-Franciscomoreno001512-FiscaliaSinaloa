using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Solicitud_de_Denuncia_Ciudadana
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Solicitud_de_Denuncia_CiudadanaService : ISolicitud_de_Denuncia_CiudadanaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana> _Solicitud_de_Denuncia_CiudadanaRepository;
        #endregion

        #region Ctor
        public Solicitud_de_Denuncia_CiudadanaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana> Solicitud_de_Denuncia_CiudadanaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Solicitud_de_Denuncia_CiudadanaRepository = Solicitud_de_Denuncia_CiudadanaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana> SelAll(bool ConRelaciones)
        {
            return this._Solicitud_de_Denuncia_CiudadanaRepository.Table.ToList();
        }

        public IList<Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana> SelAllComplete(bool ConRelaciones)
        {
            return this._Solicitud_de_Denuncia_CiudadanaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Solicitud_de_Denuncia_CiudadanaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Solicitud_de_Denuncia_CiudadanaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Solicitud_de_Denuncia_CiudadanaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_CiudadanaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Solicitud_de_Denuncia_CiudadanaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Solicitud_de_Denuncia_CiudadanaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Solicitud_de_Denuncia_CiudadanaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana entity, Spartane.Core.Domain.User.GlobalData Solicitud_de_Denuncia_CiudadanaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana entity, Spartane.Core.Domain.User.GlobalData Solicitud_de_Denuncia_CiudadanaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

