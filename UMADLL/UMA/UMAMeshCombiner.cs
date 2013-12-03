﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace UMA
{
    public abstract class UMAMeshCombiner : MonoBehaviour
    {
        public abstract void UpdateUMAMesh(bool updatedAtlas, UMAGenerator umaGenerator);
    }
}
