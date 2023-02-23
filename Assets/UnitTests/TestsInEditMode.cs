using System.Collections;
using System.Collections.Generic;
using System;
using NUnit.Framework;
using System.Reflection;
using BaseDefense.Broadcast_messages;
using BroadcastMessages;
using UnityEngine;
using UnityEngine.TestTools;

public class TestsInEditMode
{
    [Test]
    public void CheckAddingListeners()
    {
        typeof(Messenger).
            GetMethod("AddAllListeners", BindingFlags.NonPublic | BindingFlags.Static).
            Invoke(obj: null, parameters: null);
        Assert.Greater(Messenger.Dict[MessageType.DEATH_PLAYER].Count, 0);
        Assert.Greater(Messenger.Dict[MessageType.RESTART].Count, 0);
        Messenger.Dict.Clear();
    }
}
