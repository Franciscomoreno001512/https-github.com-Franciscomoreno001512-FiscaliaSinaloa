using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_de_Indicios_de_Diligencia
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_de_Indicios_de_DiligenciaService : IDetalle_de_Indicios_de_DiligenciaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia> _Detalle_de_Indicios_de_DiligenciaRepository;
        #endregion

        #region Ctor
        public Detalle_de_Indicios_de_DiligenciaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia> Detalle_de_Indicios_de_DiligenciaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_de_Indicios_de_DiligenciaRepository = Detalle_de_Indicios_de_DiligenciaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia> SelAll(bool ConRelaciones)
        {
            return this._Detalle_de_Indicios_de_DiligenciaRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_de_Indicios_de_DiligenciaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_Indicios_de_DiligenciaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_de_Indicios_de_DiligenciaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_Indicios_de_DiligenciaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_DiligenciaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_de_Indicios_de_DiligenciaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_de_Indicios_de_DiligenciaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_de_Indicios_de_DiligenciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Indicios_de_DiligenciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Indicios_de_DiligenciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

