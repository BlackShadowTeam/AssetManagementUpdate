﻿
using Asset.DataAccess.Library.AssetSetups;
using Asset.Models.Library.EntityModels.AssetsModels.AssetSetups;
using System.Collections.Generic;

namespace Asset.BisnessLogic.Library.AssetSetups
{
    public class AssetLocationManager : IRepositoryManager<AssetLocation>
    {
        private readonly AssetLocationGetway _assetLocationGetway;

        public AssetLocationManager()
        {
            _assetLocationGetway = new AssetLocationGetway();
        }

        public AssetLocation Get(int id)
        {
            return _assetLocationGetway.Get(id);
        }

        public IEnumerable<AssetLocation> GetAll()
        {
            return _assetLocationGetway.GetAll();
        }

        public int Add(AssetLocation entity)
        {
            return _assetLocationGetway.Add(entity);
        }

        public int AddRange(IEnumerable<AssetLocation> entities)
        {
            throw new System.NotImplementedException();
        }

        public int Update(AssetLocation entity)
        {
            return _assetLocationGetway.Update(entity);
        }

        public int Remove(AssetLocation entity)
        {
            return _assetLocationGetway.Remove(entity);
        }

        public int RemoveRange(IEnumerable<AssetLocation> entities)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<AssetLocation> GetAllByOrgAndBroanc()
        {
            return _assetLocationGetway.GetAllByOrgAndBroanc();
        }

        public bool IsShortNameExist(string shortName, int orgId, int branchId)
        {
            bool isShortNameEixst = false;
            var location = _assetLocationGetway.GetByOrgAndBranchAndShortName(shortName, orgId, branchId);
            if (location != null)
            {
                isShortNameEixst = true;
            }
            return isShortNameEixst;
        }

        public IEnumerable<AssetLocation> GetAssetLocationByBranchId(int branchId)
        {
            return _assetLocationGetway.GetAssetLocationByBranchId(branchId);
        }
    }
}
