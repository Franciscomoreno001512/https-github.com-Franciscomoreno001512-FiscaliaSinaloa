using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Otras_Identificaciones_Involucrado;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Otras_Identificaciones_Involucrado
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Otras_Identificaciones_InvolucradoService : IOtras_Identificaciones_InvolucradoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado> _Otras_Identificaciones_InvolucradoRepository;
        #endregion

        #region Ctor
        public Otras_Identificaciones_InvolucradoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado> Otras_Identificaciones_InvolucradoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Otras_Identificaciones_InvolucradoRepository = Otras_Identificaciones_InvolucradoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado> SelAll(bool ConRelaciones)
        {
            return this._Otras_Identificaciones_InvolucradoRepository.Table.ToList();
        }

        public IList<Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado> SelAllComplete(bool ConRelaciones)
        {
            return this._Otras_Identificaciones_InvolucradoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Otras_Identificaciones_InvolucradoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Otras_Identificaciones_InvolucradoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Otras_Identificaciones_InvolucradoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_InvolucradoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Otras_Identificaciones_InvolucradoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Otras_Identificaciones_InvolucradoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Otras_Identificaciones_InvolucradoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado entity, Spartane.Core.Domain.User.GlobalData Otras_Identificaciones_InvolucradoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado entity, Spartane.Core.Domain.User.GlobalData Otras_Identificaciones_InvolucradoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

