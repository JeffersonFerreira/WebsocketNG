# 1.0.0 (2020-08-23)


### breaking

* AsyncFallbackTransport -> FallbackTransport ([f8f643a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f8f643a6245777279de31dc8997a7ea84328533e))
* AsyncMultiplexTransport -> MultiplexTransport ([832b7f9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/832b7f9528595e45769790c4be4fd94e873c96f4))
* Rename [Command] to [ServerRpc] ([#271](https://github.com/MirrorNG/MirrorNG_Websocket/issues/271)) ([fff7459](https://github.com/MirrorNG/MirrorNG_Websocket/commit/fff7459801fc637c641757c516f85b4d685e0ad1))
* rename AsyncWsTransport -> WsTransport ([9c394bc](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9c394bc96192a50ad273371b66c9289d75402dc6))
* Transports can now provide their Uri ([#1454](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1454)) ([b916064](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b916064856cf78f1c257f0de0ffe8c9c1ab28ce7)), closes [#38](https://github.com/MirrorNG/MirrorNG_Websocket/issues/38)


### Bug Fixes

* (again) Telepathy updated to latest version (Send SocketExceptions now disconnect the player too) ([46eddc0](https://github.com/MirrorNG/MirrorNG_Websocket/commit/46eddc01ec104f98701e5552a66728ae48d0720f))
* [#1241](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1241) - Telepathy updated to latest version. All tests are passing again. Thread.Interrupt was replaced by Abort+Join. ([228b32e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/228b32e1da8e407e1d63044beca0fd179f0835b4))
* [#1278](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1278) - only call initial state SyncVar hooks on clients if the SyncVar value is different from the default one. ([#1414](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1414)) ([a3ffd12](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a3ffd1264c2ed2780e6e86ce83077fa756c01154))
* [#1359](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1359). Revert "Destroy objects owned by this connection when disconnecting ([#1179](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1179))" ([4cc4279](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4cc4279d7ddeaf61fe300b3dc420143e63942f1f))
* [#1380](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1380) - NetworkConnection.clientOwnedObjects changed from uint HashSet to NetworkIdentity HashSet for ease of use and to fix a bug where DestroyOwnedObjects wouldn't find a netId anymore in some cases. ([a71ecdb](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a71ecdba4a020f9f4648b8275ec9d17b19aff55f))
* [#1515](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1515) - StopHost now invokes OnServerDisconnected for the host client too ([#1601](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1601)) ([678ac68](https://github.com/MirrorNG/MirrorNG_Websocket/commit/678ac68b58798816658d29be649bdaf18ad70794))
* [#1593](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1593) - NetworkRoomManager.ServerChangeScene doesn't destroy the world player before replacing the connection. otherwise ReplacePlayerForConnection removes authority form a destroyed object, causing all kidns of errors. The call wasn't actually needed. ([#1594](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1594)) ([347cb53](https://github.com/MirrorNG/MirrorNG_Websocket/commit/347cb5374d0cba72762e893645f076d3161aa0c5))
* [#1599](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1599) - NetworkManager HUD calls StopHost/Server/Client depending on state. It does not call StopHost in all cases. ([#1600](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1600)) ([8c6ae0f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/8c6ae0f8b4fdafbc3abd194c081c75ee75fcfe51))
* [#1659](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1659) Telepathy LateUpdate processes a limited amount of messages per tick to avoid deadlocks ([#1830](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1830)) ([d3dccd7](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d3dccd7a25e4b9171ac04e43a05954b56caefd4b))
* [#573](https://github.com/MirrorNG/MirrorNG_Websocket/issues/573) (part 1) NetworkScenePostProcess handles NetworkIdentities of all scenes except DontDestroyOnLoad. this way it works for additively loaded scenes too. ([c1af84e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c1af84e6bf61ff919607c66affc4a1bd0dc3fb26))
* [#573](https://github.com/MirrorNG/MirrorNG_Websocket/issues/573) (part 2) NetworkManager detects additive scene loads and respawns objects on server/client again ([e521a20](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e521a200523b25a874a3cbc743d2a9d98a88b238))
* [#573](https://github.com/MirrorNG/MirrorNG_Websocket/issues/573) NullReferenceException because destroyed NetworkIdentities were never removed from sceneIds dict ([a2d6317](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a2d6317642a24571a63bbeade5fe8898f56c1c3e))
* [#609](https://github.com/MirrorNG/MirrorNG_Websocket/issues/609) by spawning observers in NetworkServer.AddPlayerForConnection after setting the controller. There is no point in trying to spawn with a null controller in SetReady, because by definition no one can observer something that is null. ([#623](https://github.com/MirrorNG/MirrorNG_Websocket/issues/623)) ([5c00577](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5c00577746f83eadd948383dd478360e96634ea4))
* [#640](https://github.com/MirrorNG/MirrorNG_Websocket/issues/640) InternalReplacePlayerForConnection calls SpawnObserversForConnection now too ([bdf12c8](https://github.com/MirrorNG/MirrorNG_Websocket/commit/bdf12c85d01b20f2a0edc0767454401a6c5a1aad))
* [#651](https://github.com/MirrorNG/MirrorNG_Websocket/issues/651) GetSceneAt assumes default scene ([#654](https://github.com/MirrorNG/MirrorNG_Websocket/issues/654)) ([65eaba1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/65eaba1fe059db159b5fdb1427dc8b783f5720e0))
* [#652](https://github.com/MirrorNG/MirrorNG_Websocket/issues/652) OnPostProcessScene includes disabled NetworkIdentities in scene ([ee2ace8](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ee2ace8e428d67309dc219109be5853b1a9b67df))
* [#679](https://github.com/MirrorNG/MirrorNG_Websocket/issues/679) package for unity ([4a6a4df](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4a6a4df61bc65c2065cb1150cd05e15528db6b66))
* [#679](https://github.com/MirrorNG/MirrorNG_Websocket/issues/679) unity package ([9895647](https://github.com/MirrorNG/MirrorNG_Websocket/commit/98956472969ba8ae1c66d255f1094140aeb275f0))
* [#692](https://github.com/MirrorNG/MirrorNG_Websocket/issues/692) by always adding connectionToClient when rebuilding observers ([ab44ac8](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ab44ac8f8bad4749e300ba8c2db4593fcff5474f))
* [#718](https://github.com/MirrorNG/MirrorNG_Websocket/issues/718) remove Tests folder from unitypackage ([#827](https://github.com/MirrorNG/MirrorNG_Websocket/issues/827)) ([7e487af](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7e487afe512de9dc8a0d699693884cbfc9c7be7e))
* [#723](https://github.com/MirrorNG/MirrorNG_Websocket/issues/723) - NetworkTransform teleport works properly now ([fd7dc5e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/fd7dc5e226a76b27250fb503a98f23eb579387f8))
* [#791](https://github.com/MirrorNG/MirrorNG_Websocket/issues/791) corrected assembly paths passed to weaver ([#803](https://github.com/MirrorNG/MirrorNG_Websocket/issues/803)) ([3ba546e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3ba546e133dae6dd2762d7c4f719f61e90554473))
* [#791](https://github.com/MirrorNG/MirrorNG_Websocket/issues/791) stack overflow in the weaver ([#792](https://github.com/MirrorNG/MirrorNG_Websocket/issues/792)) ([7b57830](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7b57830e6c8e3b9abf470cf1029eb2e4aba914ee))
* [#840](https://github.com/MirrorNG/MirrorNG_Websocket/issues/840) by allowing Mirror to respect the forceHidden flag ([#893](https://github.com/MirrorNG/MirrorNG_Websocket/issues/893)) ([3ec3d02](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3ec3d023621e121aed302222fdb6e35ed5ca92b2))
* add Changelog metadata fix [#31](https://github.com/MirrorNG/MirrorNG_Websocket/issues/31) ([c67de22](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c67de2216aa331de10bba2e09ea3f77e6b1caa3c))
* add client only test for FinishLoadScene ([#262](https://github.com/MirrorNG/MirrorNG_Websocket/issues/262)) ([50e7fa6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/50e7fa6e287fee09afbe36a51575f41c4bd50736))
* Add missing channelId to NetworkConnectionToClient.Send calls ([#1509](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1509)) ([b8bcd9a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b8bcd9ad25895eee940a3daaf6fe7ed82eaf76ac))
* add tests for NetworkTransform and NetworkRigidbody ([#273](https://github.com/MirrorNG/MirrorNG_Websocket/issues/273)) ([e9621dd](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e9621ddebd50637680fad8fe743c7c99afea3f84))
* Add the transport first so NetworkManager doesn't add Telepathy in OnValidate ([bdec276](https://github.com/MirrorNG/MirrorNG_Websocket/commit/bdec2762821dc657e8450b576422fcf1f0f69cdf))
* Added ClientOnly check ([fb927f8](https://github.com/MirrorNG/MirrorNG_Websocket/commit/fb927f814110327867821dac8b0d69ca4251d4f6))
* Added LogFilter.Debug check in a few places ([#1575](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1575)) ([3156504](https://github.com/MirrorNG/MirrorNG_Websocket/commit/31565042708ec768fcaafe9986968d095a3a1419))
* added new read/write symbol params ([#806](https://github.com/MirrorNG/MirrorNG_Websocket/issues/806)) ([3a50ca6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3a50ca6352761b47464d0bc7721aa6556d664661))
* Added WriteBytesAndSize tests, and fixed the function to be pedantic. ([#773](https://github.com/MirrorNG/MirrorNG_Websocket/issues/773)) ([72e4e55](https://github.com/MirrorNG/MirrorNG_Websocket/commit/72e4e55778edc0acc4ef3546f69c984f0f392867))
* Adding warning when adding handler with RegisterSpawnHandler if assetid already exists ([#1819](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1819)) ([7f26329](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7f26329e2db9d00da04bed40399af053436218bd))
* Adding warning when adding prefab with RegisterPrefab if assetid already exists ([#1828](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1828)) ([9f59e0c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9f59e0c439707d66409a617b8f209187856eaf5f))
* addingNetwork rigidbody icon and AddComponentMenu attribute ([#2051](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2051)) ([ab1b92f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ab1b92f74b56787feb7c6fde87c0b9838b8d9d0f))
* Additive scene can respawn objects safely ([#1270](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1270)) ([8899d20](https://github.com/MirrorNG/MirrorNG_Websocket/commit/8899d207127be86a01cb859d0539c7927ebc2f67))
* additive scene example ([9fa0169](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9fa016957f487526ab44d443aabfe58fcc69518a))
* Additive Scene Example was missing Player Auth on movement. ([#234](https://github.com/MirrorNG/MirrorNG_Websocket/issues/234)) ([09bbd68](https://github.com/MirrorNG/MirrorNG_Websocket/commit/09bbd686e6c294f24412b35785cfa7a5aa47b5f2))
* additive scene player movement is client authoritative ([e683a92](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e683a92b081c989314c11e48fb21ee0096465797))
* AdditiveSceneExample missing comp and assignments ([#267](https://github.com/MirrorNG/MirrorNG_Websocket/issues/267)) ([ab394b8](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ab394b8f7e823b8c3882de35eaa54c05fbd9316e))
* Allow sync objects to be re-used ([#1744](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1744)) ([58c89a3](https://github.com/MirrorNG/MirrorNG_Websocket/commit/58c89a3d32daedc9b6670ed0b5eb1f8753c902e2)), closes [#1714](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1714)
* Allowing overrides for virtual commands to call base method ([#1944](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1944)) ([b92da91](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b92da91d7a04f41098615ff2e2a35cf7ff479201))
* ArraySegment<byte> work in Messages ([#919](https://github.com/MirrorNG/MirrorNG_Websocket/issues/919)) ([981ba7c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/981ba7c2b3a64ebd9e1405e5182daa030886d792))
* assign spawn locations and fix null refs in example ([#242](https://github.com/MirrorNG/MirrorNG_Websocket/issues/242)) ([3adf343](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3adf3438578ff304f1216022aae8e043c52cd71d))
* AsyncTcp now exits normally when client disconnects ([#141](https://github.com/MirrorNG/MirrorNG_Websocket/issues/141)) ([8896c4a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/8896c4afa2f937839a54dc71fbe578b9c636f393))
* attributes causing a NRE ([#69](https://github.com/MirrorNG/MirrorNG_Websocket/issues/69)) ([fc99c67](https://github.com/MirrorNG/MirrorNG_Websocket/commit/fc99c67712564e2d983674b37858591903294f1a))
* auto reference mirrorng assembly ([93f8688](https://github.com/MirrorNG/MirrorNG_Websocket/commit/93f8688b39822bb30ed595ca36f44a8a556bec85))
* Avoid FindObjectOfType when not needed ([#66](https://github.com/MirrorNG/MirrorNG_Websocket/issues/66)) ([e2a4afd](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e2a4afd0b9ca8dea720acb9c558efca210bd8e71))
* better error for Command, ClientRpc and TargetRpc marked as abstract ([#1947](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1947)) ([62257d8](https://github.com/MirrorNG/MirrorNG_Websocket/commit/62257d8c4fc307ba3e23fbd01dcc950515c31e79))
* Better errors when trying to replace existing assetid ([#1827](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1827)) ([822b041](https://github.com/MirrorNG/MirrorNG_Websocket/commit/822b04155def9859b24900c6e55a4253f85ebb3f))
* build in IL2CPP ([#1524](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1524)) ([59faa81](https://github.com/MirrorNG/MirrorNG_Websocket/commit/59faa819262a166024b16d854e410c7e51763e6a)), closes [#1519](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1519) [#1520](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1520)
* call callback after update dictionary in host ([#1476](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1476)) ([1736bb0](https://github.com/MirrorNG/MirrorNG_Websocket/commit/1736bb0c42c0d2ad341e31a645658722de3bfe07))
* Call hooks when initializing objects OnStartServer on host ([#1249](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1249)) ([7aa7815](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7aa7815754bb3be1071884d6583076badc7cae59))
* call Obsoleted OnStartClient ([#681](https://github.com/MirrorNG/MirrorNG_Websocket/issues/681)) ([8dea50e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/8dea50ed18ca45e72cc5e5addf1cc28c7ab08746))
* call OnStartClient only once in room ([#1264](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1264)) ([4d373c5](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4d373c5071c45201146333f40d3fbc5d1fa8ec26))
* call the virtual OnRoomServerDisconnect before the base ([e6881ef](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e6881ef007f199efca3c326ead258f0c350ffb47))
* calling base method when the first base class did not have the virtual method ([#2014](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2014)) ([4af72c3](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4af72c3a63e72dac6b3bab193dc58bfa3c44a975))
* calling Connect and Authenticate handler twice ([#102](https://github.com/MirrorNG/MirrorNG_Websocket/issues/102)) ([515f5a1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/515f5a15cd5be984f8cb4f94d3be0a0ac919eb63))
* calling syncvar hook when not connected yet ([#77](https://github.com/MirrorNG/MirrorNG_Websocket/issues/77)) ([e64727b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e64727b74bcbb1adfcd8f5efbf96066443254dff))
* changing namespace to match folder name ([#2037](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2037)) ([e36449c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e36449cb22d8a2dede0133cf229bc12885c36bdb))
* chat example ([e6e10a7](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e6e10a7108bc01e3bd0c208734c97c945003ff86))
* chat example works ([0609d50](https://github.com/MirrorNG/MirrorNG_Websocket/commit/0609d50d9b93afd3b42d97ddcd00d32e8aaa0db5))
* check event prefix ([7417b68](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7417b6867175f0a54db56efc4387d2d24b0b37dd))
* Check SceneManager GetSceneByName and GetSceneByPath ([#1684](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1684)) ([e7cfd5a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e7cfd5a498c7359636cd109fe586fce1771bada2))
* Clean up roomSlots on clients in NetworkRoomPlayer ([5032ceb](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5032ceb00035679e0b80f59e91131cdfa8e0b1bb))
* Cleaning up network objects when server stops ([#1864](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1864)) ([4c25122](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4c25122958978557173ec37ca400c47b2d8e834f))
* cleanup the server even after error ([#255](https://github.com/MirrorNG/MirrorNG_Websocket/issues/255)) ([7bd015e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7bd015eac1b77f0ad5974abb5c4c87a5d3da7b6d))
* clear all message handlers on Shutdown ([#1829](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1829)) ([a6ab352](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a6ab3527acb9af8f6a68f0151e5231e4ee1a98e9))
* client being disconnected twice ([#132](https://github.com/MirrorNG/MirrorNG_Websocket/issues/132)) ([36bb3a2](https://github.com/MirrorNG/MirrorNG_Websocket/commit/36bb3a2418bcf41fd63d1fc79e8a5173e4b0bc51))
* client disconnected on server event never raised ([#133](https://github.com/MirrorNG/MirrorNG_Websocket/issues/133)) ([9d9efa0](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9d9efa0e31cbea4d90d7408ae6b3742151b49a21))
* ClientRpc methods now work accross assemblies ([#1129](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1129)) ([13dbcb9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/13dbcb9f35d64285258e748ca1fd5c4daac97a16)), closes [#1128](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1128)
* Cmds can be called from child classes in other assemblies ([d8a98d8](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d8a98d8d996aeded693223b00b90f2eea5084c11)), closes [#1108](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1108)
* code generation works with il2cpp again ([#1056](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1056)) ([8738562](https://github.com/MirrorNG/MirrorNG_Websocket/commit/87385628f0836109fb009b1f912575c5c8145005))
* code smell rename Ready ([#256](https://github.com/MirrorNG/MirrorNG_Websocket/issues/256)) ([6d92d14](https://github.com/MirrorNG/MirrorNG_Websocket/commit/6d92d1482cdd31fa663f7475f103476c65b7d875))
* Command and Rpc debugging information ([#1551](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1551)) ([658847b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/658847b096571eb7cf14e824ea76359576121e63)), closes [#1550](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1550)
* comment punctuation ([4d827cd](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4d827cd9f60e4fb7cd6524d78ca26ea1d88a1eff))
* compilation error ([df7baa4](https://github.com/MirrorNG/MirrorNG_Websocket/commit/df7baa4db0d347ee69c17bad9f9e56ccefb54fab))
* compilation error ([dc74256](https://github.com/MirrorNG/MirrorNG_Websocket/commit/dc74256fc380974ad6df59b5d1dee3884b879bd7))
* compilation error on standalone build ([bb70bf9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/bb70bf963459be02a79c2c40cb7dfb8f10d2b92d))
* compilation issue after merge from mirror ([daf07be](https://github.com/MirrorNG/MirrorNG_Websocket/commit/daf07bea83c9925bd780e23de53dd50604e8a999))
* compilation issues ([22bf925](https://github.com/MirrorNG/MirrorNG_Websocket/commit/22bf925f1ebf018b9ea33df22294fb9205574fa5))
* comply with MIT license in upm package ([b879bef](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b879bef4295e48c19d96a1d45536a11ea47380f3))
* Decouple ChatWindow from player ([#1429](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1429)) ([42a2f9b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/42a2f9b853667ef9485a1d4a31979fcf1153c0d7))
* Default port is 7777 ([960c39d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/960c39da90db156cb58d4765695664f0c084b39a))
* destroy owned objects ([#1352](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1352)) ([d7a58d2](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d7a58d25d4aa79d31dfc3fadfa4f68a5fdb895e6)), closes [#1346](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1346) [#1206](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1206) [#1351](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1351)
* Destroyed NetMan due to singleton collision must not continue. ([#1636](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1636)) ([d2a58a4](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d2a58a4c251c97cdb38c88c9a381496b3078adf8))
* disconnect even if there is an exception ([#152](https://github.com/MirrorNG/MirrorNG_Websocket/issues/152)) ([2eb9de6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2eb9de6b470579b6de75853ba161b3e7a36de698))
* disconnect properly from the server ([c89bb51](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c89bb513e536f256e55862b723487bb21281572e))
* disconnect transport without domain reload ([20785b7](https://github.com/MirrorNG/MirrorNG_Websocket/commit/20785b740e21fb22834cd01d7d628e127df6b80d))
* do not accumulate changes if there are no observers fixes [#963](https://github.com/MirrorNG/MirrorNG_Websocket/issues/963) ([#964](https://github.com/MirrorNG/MirrorNG_Websocket/issues/964)) ([64a0468](https://github.com/MirrorNG/MirrorNG_Websocket/commit/64a046803ada79f7602f6e6fda21d821909fbc98))
* Do not call InternalAddPlayer twice ([#1246](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1246)) ([7119dd1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7119dd15f8e90e6d6bc929a9e4633082615d0023))
* don't call hook in host if no change,  fixes [#1142](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1142) ([#1143](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1143)) ([d8ce80f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d8ce80fe0edb243a71d35bdae657805b18a8a85e))
* don't call OnStartLocalPlayer twice ([#1263](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1263)) ([c753089](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c7530894788bb843b0f424e8f25029efce72d8ca))
* Don't call RegisterClientMessages every scene change ([#1865](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1865)) ([05c119f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/05c119f505390094c8f33e11568d40117360c49e))
* Don't call RegisterClientMessages twice ([#1842](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1842)) ([2a08aac](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2a08aac7cb8887934eb7eb8c232ce07976defe35))
* don't convert null arrays to empty array ([#913](https://github.com/MirrorNG/MirrorNG_Websocket/issues/913)) ([dd758ca](https://github.com/MirrorNG/MirrorNG_Websocket/commit/dd758cac0578629e351bf60d25733d788bd0f668))
* don't crash when stopping the client ([f584388](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f584388a16e746ac5c3000123a02a5c77387765e))
* Don't destroy the player twice ([#1709](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1709)) ([cbc2a47](https://github.com/MirrorNG/MirrorNG_Websocket/commit/cbc2a4772921e01db17033075fa9f7d8cb7e6faf))
* Don't disconnect host ([#608](https://github.com/MirrorNG/MirrorNG_Websocket/issues/608)) ([c1707e5](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c1707e5917c4058a9641376d028f5feff51128cc))
* Don't give host player authority by default ([#1158](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1158)) ([1fc1ed2](https://github.com/MirrorNG/MirrorNG_Websocket/commit/1fc1ed27081413e48a7898fc185cb238ed0074dc))
* Don't increment counter in Awake ([#971](https://github.com/MirrorNG/MirrorNG_Websocket/issues/971)) ([45b7118](https://github.com/MirrorNG/MirrorNG_Websocket/commit/45b711804b1159e390910227796f312f74351025))
* don't report error when stopping the server ([c965d4b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c965d4b0ff32288ebe4e5c63a43e32559203deb1))
* Don't set asset id for scene objects ([7e40232](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7e4023246bc2e6a11909a7c3730ae05ee56d1369))
* Don't set framerate in host mode ([4644bc4](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4644bc4b7730d4aefae833fb59264230026bb4d0))
* Don't throw exception getting address ([7df3ce3](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7df3ce37d1a23b8137119015276436a741b7cd9d))
* don't use obsolete method ([12437ba](https://github.com/MirrorNG/MirrorNG_Websocket/commit/12437ba9c2ccc72998f2dd895b888d8eaa66e7a6))
* Draw SyncVar label for Unity objects inline  ([#1291](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1291)) ([a0425e4](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a0425e4e84cb08c3fd8d7e7fe07a230579d0c0c7))
* Dummy file for SyncListStructProcessor.cs ([#798](https://github.com/MirrorNG/MirrorNG_Websocket/issues/798)) ([75e4f15](https://github.com/MirrorNG/MirrorNG_Websocket/commit/75e4f159e516f8f3b04b6f1a2c77898de8c7c7b5))
* Eliminate NetworkAnimator SetTrigger double firing on Host ([#1723](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1723)) ([e5b728f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e5b728fed515ab679ad1e4581035d32f6c187a98))
* empty scene name isn't considered as empty ([ec3a939](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ec3a93945b5b52a77fd745b39e1e821db721768d))
* error when there are no network behaviors ([#1303](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1303)) ([dbe0643](https://github.com/MirrorNG/MirrorNG_Websocket/commit/dbe064393a6573bcb213b628ec53b547d04891cc))
* error with missing assemblies ([#1052](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1052)) ([00eb23a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/00eb23aa01210860b9c8ab253929563f695714d7)), closes [#1051](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1051)
* examples now work with prefabs in NC ([df4149b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/df4149b8fea9f174742d20f600ef5261058e5300))
* examples run in background ([#233](https://github.com/MirrorNG/MirrorNG_Websocket/issues/233)) ([4755650](https://github.com/MirrorNG/MirrorNG_Websocket/commit/47556500eed7c0e2719e41c0e996925ddf1799bb))
* Fallback and Multiplex now disable their transports when they are disabled  ([#2048](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2048)) ([61d44b2](https://github.com/MirrorNG/MirrorNG_Websocket/commit/61d44b2d80c9616f784e855131ba6d1ee8a30136))
* FinishLoadSceneHost calls FinishStart host which now calls StartHostClient AFTER server online scene was loaded. Previously there was a race condition where StartHostClient was called immediately in StartHost, before the scene change even finished. This was still from UNET. ([df9c29a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/df9c29a6b3f9d0c8adbaff5a500e54abddb303b3))
* first connection id = 1 ([#60](https://github.com/MirrorNG/MirrorNG_Websocket/issues/60)) ([891dab9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/891dab92d065821ca46b47ef2d3eb27124058d74))
* fix adding and saving Components ([2de7ecd](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2de7ecd93029bf5fd2fbb04ad4e47936cbb802cc))
* Fix error scene error message in host mode ([838d4f0](https://github.com/MirrorNG/MirrorNG_Websocket/commit/838d4f019f60e202b3795a01e4297c2d3efe6bca))
* fix release pipeline ([2a3db0b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2a3db0b398cd641c3e1ba65a32b34822e9c9169f))
* Fix Room Slots for clients ([#1439](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1439)) ([268753c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/268753c3bd0a9c0695d8d4510a129685be364a11))
* Fixed Capitalization ([c45deb8](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c45deb808e8e01a7b697e703be783aea2799d4d1))
* Fixed ClienRpc typos ([e946c79](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e946c79194dd9618992a4136daed4b79f60671a2))
* Fixed NetworkRoomManager Template ([1662c5a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/1662c5a139363dbe61784bb90ae6544ec74478c3))
* Fixed toc link ([3a0c7fb](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3a0c7fb1ecd9d8715e797a7665ab9a6a7cb19e2a))
* Fixing ClientScene UnregisterPrefab ([#1815](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1815)) ([9270765](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9270765bebf45c34a466694473b43c6d802b99d9))
* Fixing SyncVars not serializing when OnSerialize is overridden ([#1671](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1671)) ([c66c5a6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c66c5a6dcc6837c840e6a51435b88fde10322297))
* folders for meta files no longer in the codebase ([#237](https://github.com/MirrorNG/MirrorNG_Websocket/issues/237)) ([192fd16](https://github.com/MirrorNG/MirrorNG_Websocket/commit/192fd1645986c515a804a01e0707c78241882676))
* hasAuthority is now visible in all overrides ([#1251](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1251)) ([2f19c7c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2f19c7ca8961e9d99794e6053abfa88263dea89d)), closes [#1250](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1250)
* headless build ([7864e8d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7864e8d6f4a0952ef3114daac11842e4ee0a7a58))
* headless build ([ab47a45](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ab47a45d08f4e9a82a5cd26f913f4871d46dd484))
* hooks in host mode can call each other ([#1017](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1017)) ([f27fd0b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f27fd0bdc570ec3ceeef433eb4991beb487d2ddb))
* Host Player Ready Race Condition ([#1498](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1498)) ([4c4a52b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4c4a52bff95e7c56f065409b1399955813f3e145))
* If socket is undefined it will return false. See [#1486](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1486) ([#2017](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2017)) ([4ffff19](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4ffff192a69108b993cf963cfdece47b14ffdbf2))
* Improved error checking for ClientScene.RegisterPrefab ([#1823](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1823)) ([a0aa4f9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a0aa4f9c1425d4eca3fe08cd2d87361f092ded6f))
* Improved error checking for ClientScene.RegisterPrefab with handler ([#1841](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1841)) ([54071da](https://github.com/MirrorNG/MirrorNG_Websocket/commit/54071da3afb18d6289de5d0e41dc248e21088641))
* invalid scene id in 2019.1 by ignoring prefabs in NetworkScenePostProcess ([203a823](https://github.com/MirrorNG/MirrorNG_Websocket/commit/203a823b19b6e31a50cd193a7bd58c33a73960f2))
* Invoke server.Disconnected before identity is removed for its conn ([#165](https://github.com/MirrorNG/MirrorNG_Websocket/issues/165)) ([b749c4b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b749c4ba126266a1799059f7fb407b6bcaa2bbd9))
* isClient now reports true onStartServer in host mode ([#1252](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1252)) ([d00c95b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d00c95bb55eedceb4f0811de54604c960c9352fe))
* isLocalPlayer is true during OnStartClient for Player ([#1255](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1255)) ([fb26d00](https://github.com/MirrorNG/MirrorNG_Websocket/commit/fb26d0023f2ecfcec710d365f23a19036e3f87b2)), closes [#1250](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1250)
* isLocalPlayer works in host mode onStartServer ([#1253](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1253)) ([9acde20](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9acde20b0a4237936fc028747551204208ac9677)), closes [#1250](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1250)
* it is not safe to modify this outside this class ([bc7a961](https://github.com/MirrorNG/MirrorNG_Websocket/commit/bc7a961e4db0b269e36cd15f1492410932ff7f5b))
* list server logs properly when disconnected ([f02d317](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f02d3174db39498749a6663984dcb4bea8ac342e))
* ListServer Ping not found in WebGL ([6c4b34b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/6c4b34ba065429b57ccfed71ac0adc325de19809))
* Lobby Remove button not showing for P1 when Server Only ([377c47c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/377c47ce74808dc7d2871eac80c4cd040894821b))
* maintain Unity's copyright notice ([#961](https://github.com/MirrorNG/MirrorNG_Websocket/issues/961)) ([7718955](https://github.com/MirrorNG/MirrorNG_Websocket/commit/771895509a358286377ea3d391ca45f8c0a3b48d))
* Make assembly definition 2018.4 compatible ([99ecc9e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/99ecc9ec770aa89d5087e5b95821ff3e2e444085))
* make build pass ([08df6d0](https://github.com/MirrorNG/MirrorNG_Websocket/commit/08df6d0694b10475301b21915214cbbfbbec2826))
* Make SendToReady non-ambiguous ([#1578](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1578)) ([b627779](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b627779acd68b2acfcaf5eefc0d3864dcce57fc7))
* making weaver include public fields in base classes in auto generated Read/Write ([#1977](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1977)) ([3db57e5](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3db57e5f61ac0748d3a6296d8ea44c202830796f))
* Mark weaver as failed if serializing invalid type ([03c767d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/03c767db6aea583bb00e56b1ac74bf29e8169a91))
* Message base class not being Serialized if processed in the wrong order ([#2023](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2023)) ([3418fa2](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3418fa210602cf1a9b9331b198ac47d8a3cabe69))
* MirrorNG works with 2019.2 ([9f35d6b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9f35d6be427843aa7dd140cde32dd843c62147ce))
* Misc Code Smells ([#257](https://github.com/MirrorNG/MirrorNG_Websocket/issues/257)) ([278a127](https://github.com/MirrorNG/MirrorNG_Websocket/commit/278a1279dabefe04b0829015841de68b41e60a7b))
* Misc code smells ([#269](https://github.com/MirrorNG/MirrorNG_Websocket/issues/269)) ([23dcca6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/23dcca61ff7c41e8b9f61579605fd56ee82c70e0))
* missed ushort reader/writer ([74faf2a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/74faf2a95b5a3e551e7ae344d5772e10ee198318))
* missing meta ([87ace4d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/87ace4dda09331968cc9d0185ce1de655f5dfb15))
* Mono.CecilX namespace to work around Unity 2019 Cecil namespace collision ([#832](https://github.com/MirrorNG/MirrorNG_Websocket/issues/832)) ([5262592](https://github.com/MirrorNG/MirrorNG_Websocket/commit/52625923b2d408018f61506ef93b15487764d095))
* move listserver classes into package ([2668b17](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2668b17162e5a9fbdce2cfc776f80044f9f4d0d9))
* move NetworkStreamExtension in a namespace ([12de543](https://github.com/MirrorNG/MirrorNG_Websocket/commit/12de543aa4da49edf3c14c69388f739ad315c84d))
* movement in room demo ([49f7904](https://github.com/MirrorNG/MirrorNG_Websocket/commit/49f7904b4a83fc5318031d273cb10a4b87af2172))
* MultiplexTransport GetMaxMessageSize NullReferenceException when called on server. And fixes potential exploits / out of sync issues where clients with different transports might see different game states because of different max message sizes. ([#1332](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1332)) ([b3127be](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b3127beb89c20447bf8044fd3bae71ae04f553e7))
* Network rigidbody fixes ([#2050](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2050)) ([0c30d33](https://github.com/MirrorNG/MirrorNG_Websocket/commit/0c30d3398aaabcbf094a88a9c9c77ab4d5062acf))
* NetworkBehaviour.SyncVarGameObjectEqual made protected again so that Weaver finds it again ([165a1dd](https://github.com/MirrorNG/MirrorNG_Websocket/commit/165a1dd94cd1a7bebc3365c4f40f968f500043a5))
* NetworkBehaviour.SyncVarNetworkIdentityEqual made protected again so that Weaver finds it again ([20a2d09](https://github.com/MirrorNG/MirrorNG_Websocket/commit/20a2d09d07ab2c47a204e5d583b538a92f72231e))
* NetworkBehaviourInspector wouldn't show SyncMode if syncvars / syncobjects were only private ([ed572da](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ed572da6a07791a243715796304c0f7695792225))
* NetworkClient.Shutdown calls ClientScene.Shutdown again to properly clean up client scene. ClientScene only cleans up itself without touching transport or NetworkIdentities (fixes the bug where the player object wouldn't be destroyed after calling StopClient) ([fb716df](https://github.com/MirrorNG/MirrorNG_Websocket/commit/fb716df12997417ce41a063508937d68a75991bf))
* NetworkConnectionEvent should be serialized in editor ([0e756ce](https://github.com/MirrorNG/MirrorNG_Websocket/commit/0e756cec06c5fda9eb4b5c8aa9de093c32b0315c))
* NetworkIdentity.OnStartLocalPlayer catches exceptions now too. fixes a potential bug where an exception in PlayerInventory.OnStartLocalPlayer would cause PlayerEquipment.OnStartLocalPlayer to not be called ([5ed5f84](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5ed5f844090442e16e78f466f7a785881283fbd4))
* NetworkIdentity.RebuildObservers: added missing null check for observers coming from components that implement OnRebuildObservers. Previously this caused a NullReferenceException. ([a5f495a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a5f495a77485b972cf39f8a42bae6d7d852be38c))
* NetworkIdentity.SetClientOwner: overwriting the owner was still possible even though it shouldn't be. all caller functions double check and return early if it already has an owner, so we should do the same here. ([548db52](https://github.com/MirrorNG/MirrorNG_Websocket/commit/548db52fdf224f06ba9d8b2d75460d31181b7066))
* NetworkManager OnValidate wouldn't properly save the automatically added Transport before because Undo.RecordObject is needed for that now. ([524abfc](https://github.com/MirrorNG/MirrorNG_Websocket/commit/524abfc5e8c881d2088a7f9f8bbf07c0371785cf))
* NetworkRoomManager.minPlayers is now protected so it's available for derived classes. ([3179f08](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3179f08e3dc11340227a57da0104b1c8d1d7b45d))
* NetworkServer.SpawnObjects: return false if server isn't running ([d4d524d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d4d524dad2a0a9d89538e6212dceda6bea71d2b7))
* NetworkTransform clientAuthority works again via clientAuthority option that is configurable in inspector. this had to be fixed after we removed local authority. ([d712cd0](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d712cd03039aea92083b1be97197f6272b2296b5))
* NinjaWS code smells ([#272](https://github.com/MirrorNG/MirrorNG_Websocket/issues/272)) ([71d9428](https://github.com/MirrorNG/MirrorNG_Websocket/commit/71d942804c0d404f287dc51b7bcdd1fcc39bcee8))
* no longer requires hook to be the first overload in a class ([#1913](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1913)) ([0348699](https://github.com/MirrorNG/MirrorNG_Websocket/commit/03486997fb0abb91d14f233658d375f21afbc3e3))
* non ready connections should not observe objects ([1352334](https://github.com/MirrorNG/MirrorNG_Websocket/commit/135233474752373b473b6094fe52bcb3ab3c4eae))
* not removing server if id is empty ([#2078](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2078)) ([f717945](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f7179455256bb7341ffa9e6921fe0de50498150a))
* NRE on gamemanager in scene ([#268](https://github.com/MirrorNG/MirrorNG_Websocket/issues/268)) ([58a124a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/58a124a99c267091142f00adc7f8898160a9dd97))
* NRE when destroying all objects ([#85](https://github.com/MirrorNG/MirrorNG_Websocket/issues/85)) ([71e78a7](https://github.com/MirrorNG/MirrorNG_Websocket/commit/71e78a7f5e15f99af89cd15c1ddd8a975e463916))
* null reference exception ([7ce95c5](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7ce95c5cea58446549d9a282b48c2e8b3f7c8323))
* OnClientEnterRoom should only fire on clients ([d9b7bb7](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d9b7bb735729e68ae399e1175d6c485a873b379e))
* OnClientReady is called and passed the appropriate ready state value in NetworkLobbyPlayer ([#618](https://github.com/MirrorNG/MirrorNG_Websocket/issues/618)) ([c9eac57](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c9eac57ce858d5977a03979e7514f9833a958d3c))
* OnSetHostVisibility can now check if it has authority ([888e46c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/888e46c6850c9d32c6428f72d0dddf5f7e8a8564))
* Optional Server or Client for PlayerSpawner ([#231](https://github.com/MirrorNG/MirrorNG_Websocket/issues/231)) ([3fa5f89](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3fa5f89d8c934b233330efe52b42e59198a920cb))
* overriden hooks are invoked (fixes [#1581](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1581)) ([#1584](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1584)) ([cf55333](https://github.com/MirrorNG/MirrorNG_Websocket/commit/cf55333a072c0ffe36a2972ca0a5122a48d708d0))
* pack works if message is boxed ([55c9bb6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/55c9bb625aa06ab83c2350b483eaca09b463db0a))
* pass the correct connection to TargetRpcs ([#146](https://github.com/MirrorNG/MirrorNG_Websocket/issues/146)) ([9df2f79](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9df2f798953f78de113ef6fa9fea111b03a52cd0))
* Pass the name of the invoking class and desired command when an object has no authority. ([#1216](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1216)) ([701f4f4](https://github.com/MirrorNG/MirrorNG_Websocket/commit/701f4f41838a01d9268335d16380f871abaf8cf5))
* port network discovery ([d6a1154](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d6a1154e98c52e7873411ce9d7b87f7b294dc436))
* Potential DOS attack by sending invalid UTF8 byte sequences  ([#727](https://github.com/MirrorNG/MirrorNG_Websocket/issues/727)) ([3cee3ab](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3cee3abc48fa58ab2bdb6affc8cbd4ae8b4fa815))
* Potential DOS attack on server by sending packed ulongs when packed uints are expected. ([#730](https://github.com/MirrorNG/MirrorNG_Websocket/issues/730)) ([015d0d5](https://github.com/MirrorNG/MirrorNG_Websocket/commit/015d0d508e193a694b254c182dcb0a906fe1f3bc))
* potential exploits / out of sync issues where clients with different transports might see different game states because of different max message sizes when using FallbackTransport. ([#1331](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1331)) ([5449840](https://github.com/MirrorNG/MirrorNG_Websocket/commit/54498403a540db62b3ac1994494ff071327330c9))
* potential null reference exception with debug logging ([33493a0](https://github.com/MirrorNG/MirrorNG_Websocket/commit/33493a0137a899754c433c428b13e6f6c621300b))
* Prevent Compiler Paradox ([#1145](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1145)) ([fd43c67](https://github.com/MirrorNG/MirrorNG_Websocket/commit/fd43c67d6866ede681024d3753b17ab5427e16f4))
* Prevent Double Call of NetworkServer.Destroy ([#1554](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1554)) ([2d1b142](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2d1b142276193be1e93a3a3f6ce482c87a134a2c))
* Prevent host client redundantly changing to offline scene ([b4511a0](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b4511a0637958f10f4a482364c654d1d9add5ef2))
* prevent NRE when operating as a separated client and server ([#283](https://github.com/MirrorNG/MirrorNG_Websocket/issues/283)) ([e10e198](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e10e198b4865fc8c941244c3e368eebc6cf73179))
* properly detect NT rotation ([#1516](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1516)) ([f0a993c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f0a993c1064384e0b3bd690d4d66be38875ed50e))
* properly stop client and server in OnApplicationQuit so that clients still get a chance to send then 'quit' packet instead of just timing out. Also fixes a bug where OnStopServer/OnStopClient were not called when stopping the Editor. ([#936](https://github.com/MirrorNG/MirrorNG_Websocket/issues/936)) ([d6389e6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d6389e68be3a951f3ddb9aa51c57a0e3c788e5f6))
* race condition closing tcp connections ([717f1f5](https://github.com/MirrorNG/MirrorNG_Websocket/commit/717f1f5ad783e13a6d55920e454cb91f380cd621))
* Re-enable transport if aborting additive load/unload ([#1683](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1683)) ([bc37497](https://github.com/MirrorNG/MirrorNG_Websocket/commit/bc37497ac963bb0f2820b103591afd05177d078d))
* Rebuild observers when we switch scenes, fixes [#978](https://github.com/MirrorNG/MirrorNG_Websocket/issues/978) ([#1016](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1016)) ([6dd1350](https://github.com/MirrorNG/MirrorNG_Websocket/commit/6dd135088bd0b3858dabf5d195d14d85879ead6d))
* release job requires node 10 ([3f50e63](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3f50e63bc32f4942e1c130c681dabd34ae81b117))
* release unitypackage ([#1355](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1355)) ([d0cc669](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d0cc6690178df0af02be7bfd1fa9aacd037c57be))
* remove customHandling as its no longer used ([#265](https://github.com/MirrorNG/MirrorNG_Websocket/issues/265)) ([dbd9d84](https://github.com/MirrorNG/MirrorNG_Websocket/commit/dbd9d84ee46ac90a8d78daba0c23fc9be71ca77d))
* Remove leftover AddPlayer methods now that extraData is gone ([#1751](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1751)) ([2d006fe](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2d006fe7301eb8a0194af9ce9244988a6877f8f0))
* remove pause network comment and log ([#238](https://github.com/MirrorNG/MirrorNG_Websocket/issues/238)) ([1a8c09d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/1a8c09d8a5a8cf70508d4e42e4912e3989478ff1))
* Remove RoomPlayer from roomSlots on Disconnect ([2a2f76c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2a2f76c263093c342f307856e400aeabbedc58df))
* remove samples from upm package ([#25](https://github.com/MirrorNG/MirrorNG_Websocket/issues/25)) ([a71e21f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a71e21fe6953f6edf54fed3499801e271e2447f3))
* remove scriptableobject error Tests ([479b78b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/479b78bf3cabe93938bf61b7f8fd63ba46da0f4a))
* remove tests from npm package ([#32](https://github.com/MirrorNG/MirrorNG_Websocket/issues/32)) ([5ed9b4f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5ed9b4f1235d5d1dc54c3f50bb1aeefd5dbe3038))
* remove Tests from UPM ([#33](https://github.com/MirrorNG/MirrorNG_Websocket/issues/33)) ([8f42af0](https://github.com/MirrorNG/MirrorNG_Websocket/commit/8f42af0a3992cfa549eb404ad9f9693101895ce9))
* remove Tests from upm package ([#34](https://github.com/MirrorNG/MirrorNG_Websocket/issues/34)) ([8d8ea0f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/8d8ea0f10743044e4a9a3d6c5b9f9973cf48e28b))
* Removed NetworkClient.Update because NetworkManager does it in LateUpdate ([984945e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/984945e482529bfc03bf735562f3eff297a1bad4))
* Removed NetworkServer.Listen because HostSetup does that ([cf6823a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/cf6823acb5151d5bc9beca2b0911a99dfbcd4472))
* Removed unnecessary registration of player prefab in NetworkRoomManager ([b2f52d7](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b2f52d78921ff0136c74bbed0980e3aaf5e2b379))
* Removed unused variable ([ae3dc04](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ae3dc04fb999c3b7133589ab631c1d23f1a8bdde))
* replace player (remove authority by default) ([#1261](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1261)) ([ad724fe](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ad724fe23c4776855ee1a2a22b53ae59ddac8992)), closes [#1257](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1257) [#1257](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1257) [#1257](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1257)
* Replaced Icosphere with centered pivot ([1dc0d98](https://github.com/MirrorNG/MirrorNG_Websocket/commit/1dc0d9837458c0403916476805f58442ff87e364))
* ReplacePlayer now calls OnStartLocalPlayer ([#1280](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1280)) ([0e1bc81](https://github.com/MirrorNG/MirrorNG_Websocket/commit/0e1bc8110fb3cc4e162464a2e080eac6c70ab95e)), closes [#962](https://github.com/MirrorNG/MirrorNG_Websocket/issues/962)
* Replacing ClearDelegates with RemoveDelegates for test ([#1971](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1971)) ([927c4de](https://github.com/MirrorNG/MirrorNG_Websocket/commit/927c4dede5930b320537150466e05112ebe70c3e))
* Report correct channel to profiler in SendToObservers ([0b84d4c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/0b84d4c5e1b8455e32eeb4d4c00b60bbc1301436))
* reset buffer every time ([a8a62a6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a8a62a64b6fa67223505505c1225269d3a047a92))
* Respect Player Prefab Position & Rotation ([#825](https://github.com/MirrorNG/MirrorNG_Websocket/issues/825)) ([8ebda0f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/8ebda0fa21b430ce1394eba8e7eeafa56d9290f3))
* return & continue on separate line ([#1504](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1504)) ([61fdd89](https://github.com/MirrorNG/MirrorNG_Websocket/commit/61fdd892d9e6882e1e51094a2ceddfadc8fd1ebc))
* Revert "NetworkClient.Shutdown: call ClientScene.Shutdown, otherwise it's never called" - caused client's player to not be removed from scene after disconnecting ([13bb748](https://github.com/MirrorNG/MirrorNG_Websocket/commit/13bb7486034b72e899365f1b0aed3707a3ac0cb1))
* Revert "NetworkIdentity.observers dictionary is always created, but always empty on clients. Gets rid of all null checks." to fix server-only bug not allowing movement on client, e.g. in uMMORPG ([f56507f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f56507f2fc9f36ca9f8e1df9a7a437a97b416d54))
* Revert "refactor:  consolidate prefab and spawn handlers ([#817](https://github.com/MirrorNG/MirrorNG_Websocket/issues/817))" to fix a bug where if editor=host, build=client, we receive scene object not found when walking out of and back into an observer's range ([1f07af0](https://github.com/MirrorNG/MirrorNG_Websocket/commit/1f07af0cae7b41cd52df621f1b5cfcefc77efdfa))
* Room example to use new override ([e1d1d41](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e1d1d41ed69f192b5fb91f92dcdeae1ee057d38f))
* rooms demo ([44598e5](https://github.com/MirrorNG/MirrorNG_Websocket/commit/44598e58325c877bd6b53ee5a77dd95e421ec404))
* Round Robin Spawning by Hierarchy Order ([#790](https://github.com/MirrorNG/MirrorNG_Websocket/issues/790)) ([531e202](https://github.com/MirrorNG/MirrorNG_Websocket/commit/531e202bbec43d855b0ba24e445588fda2f08102)), closes [#724](https://github.com/MirrorNG/MirrorNG_Websocket/issues/724)
* SceneId was not set to 0 for prefab variants ([#976](https://github.com/MirrorNG/MirrorNG_Websocket/issues/976)) ([#977](https://github.com/MirrorNG/MirrorNG_Websocket/issues/977)) ([2ca2c48](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2ca2c488acc3966ef7dc67cb530c5db9eaa8b0ea))
* SceneManager Exceptions and Tests ([#287](https://github.com/MirrorNG/MirrorNG_Websocket/issues/287)) ([388d218](https://github.com/MirrorNG/MirrorNG_Websocket/commit/388d21872bb8b4c7f9d3742ecfa9b857ee734dfa))
* SendToAll sends to that exact connection if it is detected as local connection, instead of falling back to the .localConnection field which might be something completely different. ([4b90aaf](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4b90aafe12970e00949ee43b07b9edd5213745da))
* SendToObservers missing result variable ([9c09c26](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9c09c26a5cd28cadae4049fea71cddc38c00cf79))
* SendToObservers sends to that exact connection if it is detected as local connection, instead of falling back to the .localConnection field which might be something completely different. ([4267983](https://github.com/MirrorNG/MirrorNG_Websocket/commit/426798313920d23548048aa1c678167fd9b45cbd))
* SendToReady sends to that exact connection if it is detected as local connection, instead of falling back to the .localConnection field which might be something completely different. ([4596b19](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4596b19dd959722d5dc659552206fe90c015fb01))
* set authority when replacing the player ([2195fee](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2195fee81c455ac6c2ea7cca28290fbda6f30260))
* Set syncvar variables after calling the hook ([#659](https://github.com/MirrorNG/MirrorNG_Websocket/issues/659)) ([2d63ee1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2d63ee13180a54d06ce68b641f35ee2a7702cffa))
* set version number ([#1338](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1338)) ([0d1d7b5](https://github.com/MirrorNG/MirrorNG_Websocket/commit/0d1d7b5a1c0e6d94c5749a94aa7b75f2c9a2ca0d))
* show private serializable fields in network behavior inspector ([#1557](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1557)) ([b8c87d9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b8c87d9053e7fd7c3b69bcf1d4179e6e4c9bc4a6))
* smell cleanup left if bug. repaired with parenthesis. ([#275](https://github.com/MirrorNG/MirrorNG_Websocket/issues/275)) ([dd52be3](https://github.com/MirrorNG/MirrorNG_Websocket/commit/dd52be3bb9406de7b2527c72fce90c9ed6c9d5bf))
* Spawn Handler Order ([#223](https://github.com/MirrorNG/MirrorNG_Websocket/issues/223)) ([8674274](https://github.com/MirrorNG/MirrorNG_Websocket/commit/86742740ef2707f420d5cb6aeeb257bf07511f0b)), closes [#222](https://github.com/MirrorNG/MirrorNG_Websocket/issues/222)
* spawnwithauthority works again in host mode ([5b04836](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5b04836bb220b8fc0a8c3d0a3636966af3c538f2))
* stack overflow getting logger ([55e075c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/55e075c872a076f524ec62f44d81df17819e81ba))
* Stop calling ClientDisconnect on host ([#597](https://github.com/MirrorNG/MirrorNG_Websocket/issues/597)) ([b67b3e4](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b67b3e43049405808fe123276b3637c625b0ca9b))
* StopHost with offline scene calls scene change twice ([#1409](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1409)) ([a0c96f8](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a0c96f85189bfc9b5a936a8a33ebda34b460f17f))
* Suppress warning ([fffd462](https://github.com/MirrorNG/MirrorNG_Websocket/commit/fffd462df8cc1c0265890cdfa4ceb3e24606b1c1))
* suppress warning on standalone build [#1053](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1053) ([4ef680a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4ef680a47483890d6576784ca880f2b3536b6b7f))
* Suspend server transport while changing scenes ([#1169](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1169)) ([e8fac8a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e8fac8aba5c570edfb3346c1f68ad9e5fd3b1176))
* sync events can not have the same name if they are in different classes ([#2054](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2054)) ([c91308f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c91308fb0461e54292940ce6fa42bb6cd9800d89))
* Sync full netAnimator for new clients, fix [#980](https://github.com/MirrorNG/MirrorNG_Websocket/issues/980) ([#1110](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1110)) ([db8310f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/db8310f8385ec45c28356e59d1ba4ef8f4c9ab47))
* syncvars in commands work again ([#1131](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1131)) ([c24a73f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c24a73f6c9bbe25e98a6708f05b89a63dfc54b74))
* syntax error in release job ([2eeaea4](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2eeaea41bc81cfe0c191b39da912adc565e11ec7))
* TargetRpc now works accross assemblies ([#1130](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1130)) ([5ecd646](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5ecd646134791c80d8b53759de0d8aafddc31aeb)), closes [#1128](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1128)
* tcp server Tests ([3b95477](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3b954777f16a41469d953e3744c5d68554e3d200))
* Telepathy already supports IPv6, but can no also connect to IPv4-only servers again (e.g. Mirror Booster) ([488446a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/488446ae040246a631f8921a4cd5bdbb6a6e54d1))
* Telepathy fix a bug where calling Disconnect while connecting to a dead end would freeze Unity because .Join would wait forever. Interrupt fixes it. ([3831cbd](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3831cbddbea7d98fe8a871133a0ba2bf14f22df0))
* Telepathy forgot to set socket options for accepted clients on the server ([22931fc](https://github.com/MirrorNG/MirrorNG_Websocket/commit/22931fcd84e402a60b74f5261313c830913754fc))
* Telepathy reverted to older version to fix freezes when calling Client.Disconnect on some platforms like Windows 10 ([d0d77b6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d0d77b661cd07e25887f0e2f4c2d72b4f65240a2))
* Telepathy updated to latest version (IPv6 fix again) ([535b4d4](https://github.com/MirrorNG/MirrorNG_Websocket/commit/535b4d40fa50cec9abfac37c61aaf207ecbb43b9))
* Telepathy updated to latest version (Send SocketExceptions now disconnect the player too) ([98d3fb0](https://github.com/MirrorNG/MirrorNG_Websocket/commit/98d3fb0c31b7ac8bd27ec176ebdf7fb19908d472))
* Telepathy updated to latest version: Correctly support IPv4 and IPv6 sockets ([2761ff2](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2761ff23f459b5647a5700c9b9b29abdcff13f97))
* Telepathy updated to latest version: protect against allocation attacks via MaxMessageSize. Can be configured in the TelepathyTransport component now. ([67d715f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/67d715fe7416e790bcddcd4e23bb2cb8fbbc54e8))
* Telepathy updated to latest version. connectionId counter is properly reset after stopping server. ([abf06df](https://github.com/MirrorNG/MirrorNG_Websocket/commit/abf06df25d932d3cfb016e2da0bb5e4ee72d259d))
* Telepathy updated to latest version. Threads are closed properly now. ([4007423](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4007423db28f7044f6aa97b108a6bfbe3f2d46a9))
* Telepathy works on .net core again ([cb3d9f0](https://github.com/MirrorNG/MirrorNG_Websocket/commit/cb3d9f0d08a961b345ce533d1ce64602f7041e1c))
* TelepathyTransport.ToString UWP exception ([8a190bf](https://github.com/MirrorNG/MirrorNG_Websocket/commit/8a190bfd176f043322097e64bd041e80e38cc6d2))
* the Room scene references other scenes ([9b60871](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9b60871e2ea1a2912c0af3d95796660fc04dc569))
* there is no lobby example ([b1e05ef](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b1e05efb19984ce615d20a16a6c4b09a8897da6a))
* update NetworkIdentityEditor FindProperty to renamed variables ([a2cc14b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a2cc14bd202311aa36e61804183c983c6df8c7b4))
* Updated NetworkRoomPlayer inspector and doc and image ([a4ffcbe](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a4ffcbe280e2e2318d7cd2988379af74f0d32021))
* Updated Telepathy to latest version to fix IPAddress.Parse error for "localhost" ([cc6e4f6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/cc6e4f696dbc462c3880a2c9fc73163d88351b5a))
* Use big endian for packet size ([1ddcbec](https://github.com/MirrorNG/MirrorNG_Websocket/commit/1ddcbec93509e14169bddbb2a38a7cf0d53776e4))
* Use path instead of name in Room Example ([5d4bc47](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5d4bc47d46098f920f9e3468d0f276e336488e42))
* Use ReplaceHandler instead of RegisterHandler in NetworkManager ([ffc276c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ffc276cb79c4202964275642097451b78a817c8a))
* version file ([#1337](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1337)) ([ed7e509](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ed7e509ed6f77f2e694966a1c21130e3488f443d))
* weaver Cmd/Rpc/Target prefix check is no longer trash ([#707](https://github.com/MirrorNG/MirrorNG_Websocket/issues/707)) ([699a261](https://github.com/MirrorNG/MirrorNG_Websocket/commit/699a261e91078b65f3fb1a51a5838b05be2c87d6))
* weaver now processes multiple SyncEvent per class ([#2055](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2055)) ([b316b35](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b316b35d46868a7e11c7b2005570efeec843efe1))
* weaver support array of custom types ([#1470](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1470)) ([d0b0bc9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d0b0bc92bc33ff34491102a2f9e1855f2a5ed476))
* weaver syncLists now checks for SerializeItem in base class ([#1768](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1768)) ([1af5b4e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/1af5b4ed2f81b4450881fb11fa9b4b7e198274cb))
* webgl build fix [#1136](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1136) ([#1137](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1137)) ([c85d0df](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c85d0df5332c63c0e0107e6c99cea5de37c087fc))
* Websockets Transport now handles being disabled for scene changes ([#1994](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1994)) ([5480a58](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5480a583e13b9183a3670450af639f4e766cc358))
* WebSockets: Force KeepAliveInterval to Zero ([9a42fe3](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9a42fe334251852ab12e721db72cb12e98de82e8))
* when modifying a prefab, Unity calls OnValidate for all scene objects based on that prefab, which caused Mirror to reset the sceneId because we only checked if a prefab is currently edited, not if THIS prefab is currently edited ([db99dd7](https://github.com/MirrorNG/MirrorNG_Websocket/commit/db99dd7b3d4c93969c02c5fa7b3e3a1a2948cd7e))
* workaround for [#791](https://github.com/MirrorNG/MirrorNG_Websocket/issues/791) ([5c850aa](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5c850aa9ca5b480449c453aa14191aeb9998e6cb))
* Wrong method names in ClientSceneTests ([ab3f353](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ab3f353b33b3068a6ac1649613a28b0977a72685))
* **serialization:** Added NetworkWriter tests, found and fixed a bug in Write(Ray). ([#769](https://github.com/MirrorNG/MirrorNG_Websocket/issues/769)) ([99c8f5c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/99c8f5c356d2e3bd298fbd3508a3ed2abcb04351))
* **tests:** Added missing SyncListByteValid test file ([#634](https://github.com/MirrorNG/MirrorNG_Websocket/issues/634)) ([b0af876](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b0af87622159ceca9aebf4d939a3b7ad733fbe4f))
* **weaver:** [#696](https://github.com/MirrorNG/MirrorNG_Websocket/issues/696) detect .mystruct = new MyStruct() changes with syncvars ([#702](https://github.com/MirrorNG/MirrorNG_Websocket/issues/702)) ([053949b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/053949b7d2e1e3178025a75cddb6e47b83cdbd48))
* **weaver:** fix [#706](https://github.com/MirrorNG/MirrorNG_Websocket/issues/706) find system dlls ([#729](https://github.com/MirrorNG/MirrorNG_Websocket/issues/729)) ([53be9b6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/53be9b6d9949645d5334690961ff31f90065a93a))
* **weaver:** fix [#796](https://github.com/MirrorNG/MirrorNG_Websocket/issues/796), reload assemblies after initial import ([#1106](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1106)) ([d91b387](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d91b387bb29bdba06a62a718533db5c0fe52f642))
* **websocket:** [#829](https://github.com/MirrorNG/MirrorNG_Websocket/issues/829) fix InvalidOperationException with wss:// ([#830](https://github.com/MirrorNG/MirrorNG_Websocket/issues/830)) ([2d682b5](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2d682b5fad2811d3838e8d61ccaea381cc218bb2))
* **websocket:** Remove send queues (they never worked) and SSL (temporarily) ([#879](https://github.com/MirrorNG/MirrorNG_Websocket/issues/879)) ([3c60b08](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3c60b087627175833c616619941722927aa9cd5d))
* **websocket:** Use a buffer for most WS messages in WebGL client resulting in 0 alloc for most messages ([#848](https://github.com/MirrorNG/MirrorNG_Websocket/issues/848)) ([8967a20](https://github.com/MirrorNG/MirrorNG_Websocket/commit/8967a20244a2e16e3861d60c1d13c9e808248607))


### Code Refactoring

*  Client and server keep their own spawned list ([#71](https://github.com/MirrorNG/MirrorNG_Websocket/issues/71)) ([c2599e2](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c2599e2c6157dd7539b560cd4645c10713a39276))
* observers is now a set of connections ([#74](https://github.com/MirrorNG/MirrorNG_Websocket/issues/74)) ([4848920](https://github.com/MirrorNG/MirrorNG_Websocket/commit/484892058b448012538754c4a1f2eac30a42ceaa))
* Remove networkAddress from NetworkManager ([#67](https://github.com/MirrorNG/MirrorNG_Websocket/issues/67)) ([e89c32d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e89c32dc16b3d9b9cdcb38f0d7d170da94dbf874))
* Remove offline/online scenes ([#120](https://github.com/MirrorNG/MirrorNG_Websocket/issues/120)) ([a4c881a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a4c881a36e26b20fc72166741e20c84ce030ad8f))


### Features

* [#869](https://github.com/MirrorNG/MirrorNG_Websocket/issues/869) support structs in other assemblies ([#1022](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1022)) ([62d1887](https://github.com/MirrorNG/MirrorNG_Websocket/commit/62d1887e62c7262e9e88c0c72190b82324d644e4))
* add basic example with websocket ([b85296e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b85296eaadbcfb054153f77322f4f17ccc23bba7))
* Add excludeOwner option to ClientRpc ([#1954](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1954)) ([864fdd5](https://github.com/MirrorNG/MirrorNG_Websocket/commit/864fdd5fdce7a35ee4bf553176ed7a4ec3dc0653)), closes [#1963](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1963) [#1962](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1962) [#1961](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1961) [#1960](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1960) [#1959](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1959) [#1958](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1958) [#1957](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1957) [#1956](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1956)
* Add fallback transport ([1b02796](https://github.com/MirrorNG/MirrorNG_Websocket/commit/1b02796c1468c1e1650eab0f278cd9a11cc597c7))
* Add Multiplex example with websocket ([6937f59](https://github.com/MirrorNG/MirrorNG_Websocket/commit/6937f5939de07679bb0738c0e3532d32856fb186))
* Add Network Menu  ([#253](https://github.com/MirrorNG/MirrorNG_Websocket/issues/253)) ([d81f444](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d81f444c42475439d24bf5b4abd2bbf15fd34e92))
* Add NetworkServer.RemovePlayerForConnection ([#1772](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1772)) ([e3790c5](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e3790c51eb9b79bebc48522fb832ae39f11d31e2))
* Add roomPlayer parameter to OnRoomServerCreateGamePlayer ([#1317](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1317)) ([abf5cdc](https://github.com/MirrorNG/MirrorNG_Websocket/commit/abf5cdcf36574a00995f5c229ebcbc41d0286546))
* Add Sensitivity to NetworkTransform ([#1425](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1425)) ([f69f174](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f69f1743c54aa7810c5a218e2059c115760c54a3))
* Add SyncHashSet and SyncSortedSet ([#685](https://github.com/MirrorNG/MirrorNG_Websocket/issues/685)) ([695979e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/695979e914882dd9ea80058474f147cd031d408f))
* add SyncList.RemoveAll ([#1881](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1881)) ([eb7c87d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/eb7c87d15aa2fe0a5b0c08fc9cde0adbeba0b416))
* Add UPM configuration ([#11](https://github.com/MirrorNG/MirrorNG_Websocket/issues/11)) ([9280af1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9280af158317597a53f6ddf5da4191b607e0c0f1))
* Add version to package file ([#1361](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1361)) ([e97ab93](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e97ab9379f798063e50a433ea6c2759f73d199ac))
* Add weaver support for Vector2Int and Vector3Int ([#646](https://github.com/MirrorNG/MirrorNG_Websocket/issues/646)) ([e2a6ce9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e2a6ce98114adda39bd28ec1fe31f337fc6bafc4))
* Added NetworkConnection to OnRoomServerSceneLoadedForPlayer ([b5dfcf4](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b5dfcf45bc9838e89dc37b00cf3653688083bdd8))
* Added Read<T> Method to NetworkReader ([#1480](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1480)) ([58df3fd](https://github.com/MirrorNG/MirrorNG_Websocket/commit/58df3fd6d6f53336668536081bc33e2ca22fd38d))
* Added SyncList.Find and SyncList.FindAll ([#1716](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1716)) ([0fe6328](https://github.com/MirrorNG/MirrorNG_Websocket/commit/0fe6328800daeef8680a19a394260295b7241442)), closes [#1710](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1710)
* Added Virtual OnRoomStopServer to NetworkRoomManager and Script Template ([d034ef6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d034ef616f3d479729064d652f74a905ea05b495))
* Added virtual SyncVar hook for index in NetworkRoomPlayer ([0c3e079](https://github.com/MirrorNG/MirrorNG_Websocket/commit/0c3e079d04a034f4d4ca8a34c88188013f36c377))
* adding demo for mirror cloud services ([#2026](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2026)) ([f1fdc95](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f1fdc959dcd62e7228ecfd656bc87cbabca8c1bc))
* Adding ignoreAuthority Option to Command ([#1918](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1918)) ([3ace2c6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3ace2c6eb68ad94d78c57df6f63107cca466effa))
* adding log handler that sets console color ([#2001](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2001)) ([4623978](https://github.com/MirrorNG/MirrorNG_Websocket/commit/46239783f313159ac47e192499aa8e7fcc5df0ec))
* Adding onLocalPlayerChanged to ClientScene for when localPlayer is changed ([#1920](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1920)) ([b4acf7d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b4acf7d9a20c05eadba8d433ebfd476a30e914dd))
* adding OnRoomServerPlayersNotReady to NetworkRoomManager that is called when player ready changes and atleast 1 player is not ready ([#1921](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1921)) ([9ae7fa2](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9ae7fa2a8c683f5d2a7ebe6c243a2d95acad9683))
* Adding ReplaceHandler functions to NetworkServer and NetworkClient ([#1775](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1775)) ([877f4e9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/877f4e9c729e5242d4f8c9653868a3cb27c933db))
* adding script that displays ping ([#1975](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1975)) ([7e93030](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7e93030849c98f0bc8d95fa310d208fef3028b29))
* additive scene msging added to server ([#285](https://github.com/MirrorNG/MirrorNG_Websocket/issues/285)) ([bd7a17a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/bd7a17a65fbc9aed64aaef6c65641697e8d89a74))
* allow more than one NetworkManager ([#135](https://github.com/MirrorNG/MirrorNG_Websocket/issues/135)) ([92968e4](https://github.com/MirrorNG/MirrorNG_Websocket/commit/92968e4e45a33fa5ab77ce2bfc9e8f826a888711))
* Allow Multiple Network Animator ([#1778](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1778)) ([34a76a2](https://github.com/MirrorNG/MirrorNG_Websocket/commit/34a76a2834cbeebb4c623f6650c1d67345b386ac))
* allow Play mode options ([f9afb64](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f9afb6407b015c239975c5a1fba6609e12ab5c8f))
* allow users to detect mirror version 3 ([ee9c737](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ee9c737bdaf47ff48fb72c017731fb61e63043b1))
* Allowing extra base types to be used for SyncLists and other SyncObjects ([#1729](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1729)) ([9bf816a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9bf816a014fd393617422ee6efa52bdf730cc3c9))
* Allowing Multiple Concurrent Additive Scenes ([#1697](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1697)) ([e32a9b6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e32a9b6f0b0744b6bd0eeeb0d9fca0b4dc33cbdf))
* An authenticator that times out other authenticators ([#1211](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1211)) ([09f6892](https://github.com/MirrorNG/MirrorNG_Websocket/commit/09f6892c55f74d3d480621b7d334154a979d3b6a))
* async multiplex transport ([#145](https://github.com/MirrorNG/MirrorNG_Websocket/issues/145)) ([c0e7e92](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c0e7e9280931a5996f595e41aa516bef20208b6f))
* asynchronous transport ([#134](https://github.com/MirrorNG/MirrorNG_Websocket/issues/134)) ([0e84f45](https://github.com/MirrorNG/MirrorNG_Websocket/commit/0e84f451e822fe7c1ca1cd04e052546ed273cfce))
* Authentication Framework ([#1057](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1057)) ([56bcb02](https://github.com/MirrorNG/MirrorNG_Websocket/commit/56bcb02c158050001e1910852df5994c1995424c))
* Authenticators can now provide AuthenticationData ([310ce81](https://github.com/MirrorNG/MirrorNG_Websocket/commit/310ce81c8378707e044108b94faac958e35cbca6))
* awaitable connect ([#55](https://github.com/MirrorNG/MirrorNG_Websocket/issues/55)) ([952e8a4](https://github.com/MirrorNG/MirrorNG_Websocket/commit/952e8a43e2b2e4443e24865c60af1ee47467e4cf))
* Block Play Mode and Builds for Weaver Errors ([#1479](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1479)) ([0e80e19](https://github.com/MirrorNG/MirrorNG_Websocket/commit/0e80e1996fb2673364169782c330e69cd598a21d))
* Button to register all prefabs in NetworkClient ([#179](https://github.com/MirrorNG/MirrorNG_Websocket/issues/179)) ([9f5f0b2](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9f5f0b27f8857bf55bf4f5ffbd436247f99cf390))
* Chat example ([#1305](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1305)) ([9926472](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9926472d98730d8fc77231c5ea261158bd09d46b))
* Check for client authority in CmdClientToServerSync ([#1500](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1500)) ([8b359ff](https://github.com/MirrorNG/MirrorNG_Websocket/commit/8b359ff6d07352a751f200768dcde6febd8e9303))
* Check for client authority in NetworkAnimator Cmd's ([#1501](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1501)) ([ecc0659](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ecc0659b87f3d910dc2370f4861ec70244a25622))
* Client attribute now throws error ([#274](https://github.com/MirrorNG/MirrorNG_Websocket/issues/274)) ([f1b52f3](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f1b52f3d23e9aa50b5fab8509f3c769e97eac2e7))
* ClientRpc no longer need Rpc prefix ([#2086](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2086)) ([eb93c34](https://github.com/MirrorNG/MirrorNG_Websocket/commit/eb93c34b330189c79727b0332bb66f3675cfd641))
* ClientScene uses log window ([b3656a9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b3656a9edc5ff00329ce00847671ade7b8f2add2))
* Commands no longer need Cmd prefix ([#2084](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2084)) ([b6d1d09](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b6d1d09f846f7cf0310db0db9d931a9cfbbb36b2))
* Commands no longer need to start with Cmd ([#263](https://github.com/MirrorNG/MirrorNG_Websocket/issues/263)) ([9578e19](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9578e19ff70bf3a09a9fe31926c8ac337f945ba9))
* Component based NetworkSceneManager ([#244](https://github.com/MirrorNG/MirrorNG_Websocket/issues/244)) ([7579d71](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7579d712ad97db98cd729c51568631e4c3257b58))
* component based SyncToOwner, fixes [#39](https://github.com/MirrorNG/MirrorNG_Websocket/issues/39) ([#1023](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1023)) ([c6d86b3](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c6d86b301ba19ad8bdaadff12e347f77c621cdc2))
* connections can retrieve end point ([#114](https://github.com/MirrorNG/MirrorNG_Websocket/issues/114)) ([d239718](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d239718498c5750edf0b5d11cc762136f45500fd))
* Cosmetic Enhancement of Network Manager ([#1512](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1512)) ([f53b12b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f53b12b2f7523574d7ceffa2a833dbd7fac755c9))
* Creating method to replace all log handlers ([#1880](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1880)) ([d8aaf76](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d8aaf76fb972dd153f6002edb96cd2b9350e572c))
* custom reader/writer via extension methods ([#1047](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1047)) ([b45afad](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b45afad641b1dd9cca3eb3046f6b727d7063d4ef))
* default log level option ([#1728](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1728)) ([5c56adc](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5c56adc1dc47ef91f7ee1d766cd70fa1681cb9df))
* Disconnect Dead Clients ([#1724](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1724)) ([a2eb666](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a2eb666f158d72851d6c62997ed4b24dc3c473bc)), closes [#1753](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1753)
* Disposable PooledNetworkReader / PooledNetworkWriter ([#1490](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1490)) ([bb55baa](https://github.com/MirrorNG/MirrorNG_Websocket/commit/bb55baa679ae780e127ed5817ef10d7f12cd08c8))
* Example with 10k monster that change unfrequently ([2b2e71c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2b2e71cc007dba2c1d90b565c4983814c1e0b7d1))
* Exclude fields from weaver's automatic Read/Write using System.NonSerialized attribute  ([#1727](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1727)) ([7f8733c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7f8733ce6a8f712c195ab7a5baea166a16b52d09))
* Experimental Network Transform ([#1990](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1990)) ([7e2b733](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7e2b7338a18855f156e52b663ac24eef153b43a7))
* Experimental NetworkRigidbody  ([#1822](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1822)) ([25285b1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/25285b1574c4e025373e86735ec3eb9734272fd2))
* fallback transport now supports uri ([#1296](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1296)) ([e4a701e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e4a701ed4e22f1ad89fc3805fa63fe9fef61a8e0))
* generate serializers for IMessageBase structs ([#1353](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1353)) ([3c0bc28](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3c0bc2822847410213ee137f6e848c7be296d65a))
* get a convenient property to get network time ([1e8c2fe](https://github.com/MirrorNG/MirrorNG_Websocket/commit/1e8c2fe0522d7843a6a2fae7287287c7afa4e417))
* HasAuthority attribute now throws error ([#276](https://github.com/MirrorNG/MirrorNG_Websocket/issues/276)) ([da2355b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/da2355b4c1a51dbcbf6ceb405b6fc7b5bb14fa14))
* Implement IReadOnlyList<T> in SyncLists ([#903](https://github.com/MirrorNG/MirrorNG_Websocket/issues/903)) ([3eaaa77](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3eaaa773b3c126897ed0c84c2e776045793556f7))
* Implemented NetworkReaderPool ([#1464](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1464)) ([9257112](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9257112c65c92324ad0bd51e4a017aa1b4c9c1fc))
* Improve weaver error messages ([#1779](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1779)) ([bcd76c5](https://github.com/MirrorNG/MirrorNG_Websocket/commit/bcd76c5bdc88af6d95a96e35d47b1b167d375652))
* Improved Log Settings Window Appearance ([#1885](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1885)) ([69b8451](https://github.com/MirrorNG/MirrorNG_Websocket/commit/69b845183c099744455e34c6f12e75acecb9098a))
* Improved RoomPayer template ([042b4e1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/042b4e1965580a4cdbd5ea50b11a1377fe3bf3cc))
* include generated changelog ([#27](https://github.com/MirrorNG/MirrorNG_Websocket/issues/27)) ([a60f1ac](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a60f1acd3a544639a5e58a8946e75fd6c9012327))
* Include version in release ([#1336](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1336)) ([e4f89cf](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e4f89cf12f6dca42bbb5c25e50f03ed7fcde3f82))
* individual events for SyncDictionary ([#112](https://github.com/MirrorNG/MirrorNG_Websocket/issues/112)) ([b3c1b16](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b3c1b16100c440131d6d933627a9f6479aed11ad))
* individual events for SyncSet ([#111](https://github.com/MirrorNG/MirrorNG_Websocket/issues/111)) ([261f5d6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/261f5d6a1481634dc524fb57b5866e378a1d909d))
* LAN Network discovery ([#1453](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1453)) ([e75b45f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e75b45f8889478456573ea395694b4efc560ace0)), closes [#38](https://github.com/MirrorNG/MirrorNG_Websocket/issues/38)
* LLAPI transport can receive port from uri ([#1294](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1294)) ([7865a84](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7865a840b66db74acfdf48989adec2c72222020c))
* LocalPlayer attribute now throws error ([#277](https://github.com/MirrorNG/MirrorNG_Websocket/issues/277)) ([15aa537](https://github.com/MirrorNG/MirrorNG_Websocket/commit/15aa537947cd14e4d71853f1786c387519d8828b))
* logger factory works for static classes by passing the type ([f9328c7](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f9328c771cfb0974ce4765dc0d5af01440d838c0))
* logging api ([#1611](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1611)) ([f2ccb59](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f2ccb59ae6db90bc84f8a36802bfe174b4493127))
* LogSettings that can be saved and included in a build ([#1863](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1863)) ([fd4357c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/fd4357cd264b257aa648a26f9392726b2921b870))
* Mirror Icon for all components ([#1452](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1452)) ([a7efb13](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a7efb13e29e0bc9ed695a86070e3eb57b7506b4c))
* Mirror now supports message inheritance ([#1286](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1286)) ([f9d34d5](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f9d34d586368df2917a0ee834f823a4dd140cb31))
* More examples for Mirror Cloud Service ([#2029](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2029)) ([7d0e907](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7d0e907b73530c9a625eaf663837b7eeb36fcee6))
* Multiple Concurrent Additive Physics Scenes Example ([#1686](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1686)) ([87c6ebc](https://github.com/MirrorNG/MirrorNG_Websocket/commit/87c6ebc5ddf71b3fc358bb1a90bd9ee2470e333c))
* Multiplex based on url ([#1295](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1295)) ([c206f9a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c206f9ad974249c5514fad6ef21b27387d1b7ace))
* Network Animator can reset triggers ([#1420](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1420)) ([dffdf02](https://github.com/MirrorNG/MirrorNG_Websocket/commit/dffdf02be596db3d35bdd8d19ba6ada7d796a137))
* Network Scene Checker Component ([#1271](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1271)) ([71c0d3b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/71c0d3b2ee1bbdb29d1c39ee6eca3ef9635d70bf))
* network writer and reader now support uri ([0c2556a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/0c2556ac64bd93b9e52dae34cf8d84db114b4107))
* network writer pool to avoid expensive allocations ([3659acb](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3659acbbdd43321e22269591bfd08189b40e6b44))
* network writer pool to avoid expensive allocations ([#928](https://github.com/MirrorNG/MirrorNG_Websocket/issues/928)) ([f5e9318](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f5e93180a1161e62ef74eb5c5ad81308e91d5687))
* NetworkAnimator warns if you use it incorrectly ([#1424](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1424)) ([c30e4a9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c30e4a9f83921416f936ef5fd1bb0e2b3a410807))
* NetworkClient raises event after authentication ([#96](https://github.com/MirrorNG/MirrorNG_Websocket/issues/96)) ([c332271](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c332271d918f782d4b1a84b3f0fd660239f95743))
* NetworkConnection is optional for handlers ([#1202](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1202)) ([bf9eb61](https://github.com/MirrorNG/MirrorNG_Websocket/commit/bf9eb610dced2434f4a045f5b01bc758b9f72327))
* NetworkConnection manages messages handlers ([#93](https://github.com/MirrorNG/MirrorNG_Websocket/issues/93)) ([5c79f0d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5c79f0db64e46905081e6c0b5502376c5acf0d99))
* NetworkConnection to client and server use logger framework ([72154f1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/72154f1daddaa141fb3b8fe02bcfdf098ef1d44a))
* NetworkConnection uses logging framework ([ec319a1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ec319a165dc8445b00b096d09061adda2c7b8b9d))
* NetworkIdentity lifecycle events ([#88](https://github.com/MirrorNG/MirrorNG_Websocket/issues/88)) ([9a7c572](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9a7c5726eb3d333b85c3d0e44b884c11e34be45d))
* NetworkIdentity use logger framework ([2e39e13](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2e39e13c012aa79d50a54fc5d07b85da3e52391b))
* NetworkMatchChecker Component ([#1688](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1688)) ([21acf66](https://github.com/MirrorNG/MirrorNG_Websocket/commit/21acf661905ebc35f31a52eb527a50c6eff68a44)), closes [#1685](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1685) [#1681](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1681) [#1689](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1689)
* NetworkSceneChecker use Scene instead of string name ([#1496](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1496)) ([7bb80e3](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7bb80e3b796f2c69d0958519cf1b4a9f4373268b))
* NetworkServer uses new logging framework ([8b4f105](https://github.com/MirrorNG/MirrorNG_Websocket/commit/8b4f1051f27f1d5b845e6bd0a090368082ab1603))
* NetworkServer.SendToReady ([#1773](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1773)) ([f6545d4](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f6545d4871bf6881b3150a3231af195e7f9eb8cd))
* new virtual OnStopServer called when object is unspawned ([#1743](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1743)) ([d1695dd](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d1695dd16f477fc9edaaedb90032c188bcbba6e2))
* new way to connect using uri ([#1279](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1279)) ([7c3622c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7c3622cfaed0c062f51342294264c8b389b2846d))
* new websocket transport ([#156](https://github.com/MirrorNG/MirrorNG_Websocket/issues/156)) ([23c7b0d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/23c7b0d1b32684d4f959495fe96b2d16a68bd356))
* next gen async transport ([#106](https://github.com/MirrorNG/MirrorNG_Websocket/issues/106)) ([4a8dc67](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4a8dc676b96840493d178718049b9e20c8eb6510))
* now you can assign scenes even if not in Editor ([#1576](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1576)) ([c8a1a5e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c8a1a5e56f7561487e3180f26e28484f714f36c1))
* Now you can pass NetworkIdentity and GameObjects ([#83](https://github.com/MirrorNG/MirrorNG_Websocket/issues/83)) ([dca2d40](https://github.com/MirrorNG/MirrorNG_Websocket/commit/dca2d4056fe613793480b378d25509284a1fd46a))
* onstopserver event in NetworkIdentity ([#186](https://github.com/MirrorNG/MirrorNG_Websocket/issues/186)) ([eb81190](https://github.com/MirrorNG/MirrorNG_Websocket/commit/eb8119007b19faca767969700b0209ade135650c))
* Pass all information to spawn handler ([#1215](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1215)) ([d741bae](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d741baed789366ed7ce93f289eac3552dfe54fdc))
* Piped connection ([#138](https://github.com/MirrorNG/MirrorNG_Websocket/issues/138)) ([471a881](https://github.com/MirrorNG/MirrorNG_Websocket/commit/471a881cdae1c6e526b5aa2d552cc91dc27f793a))
* PlayerSpawner component ([#123](https://github.com/MirrorNG/MirrorNG_Websocket/issues/123)) ([e8b933d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e8b933ddff9a47b64be371edb63af130bd3958b4))
* Prettify Log Names ([c7d8c09](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c7d8c0933d37abc919305b660cbf3a57828eaace))
* profiler info is available in production builds ([5649cc6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5649cc69777a4a49f11cbce92e6f149d92b6e747))
* Remove Command shortcut for host mode ([#1168](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1168)) ([94eda38](https://github.com/MirrorNG/MirrorNG_Websocket/commit/94eda38803c141f279a5f42317c4d07c16b0223d))
* safer and consistent writers names ([#979](https://github.com/MirrorNG/MirrorNG_Websocket/issues/979)) ([b4077c1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b4077c1112a529ae7494709c1da0b6351d48c4b5))
* Script Templates ([#1217](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1217)) ([8cf6a07](https://github.com/MirrorNG/MirrorNG_Websocket/commit/8cf6a0707e0ada3d27b14ec55c4c5a082f0e214b))
* Secure messages that require authentication, fixes [#720](https://github.com/MirrorNG/MirrorNG_Websocket/issues/720) ([#1089](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1089)) ([7ac43cd](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7ac43cd56af6dd1b37f6696e97d7b671d6c21865))
* Semantic release for UPM ([#24](https://github.com/MirrorNG/MirrorNG_Websocket/issues/24)) ([8cbc005](https://github.com/MirrorNG/MirrorNG_Websocket/commit/8cbc005543a8b919ec022b2e9d1b5b8a6c85ef14))
* Server and Client share the same scene loading method ([#286](https://github.com/MirrorNG/MirrorNG_Websocket/issues/286)) ([acb6dd1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/acb6dd192244adcfab15d013a96c7402151d226b))
* Server attribute now throws error ([#270](https://github.com/MirrorNG/MirrorNG_Websocket/issues/270)) ([f3b5dc4](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f3b5dc4fef5fba05e585d274d9df05c3954ff6c7))
* Server raises an event when it starts ([#126](https://github.com/MirrorNG/MirrorNG_Websocket/issues/126)) ([d5b0a6f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d5b0a6f0dd65f9dbb6c4848bce5e81f93772a235))
* ship as a unitypackage ([11edc14](https://github.com/MirrorNG/MirrorNG_Websocket/commit/11edc142cfddfb7abecc11d8a12d6d32522ceb14))
* Show compile time error if overriding unused OnServerAddPlayer ([#682](https://github.com/MirrorNG/MirrorNG_Websocket/issues/682)) ([a8599c1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a8599c1af2b3b2abe377a580760cb13bbb3c9c7d))
* Spawn objects in clients in same order as server ([#247](https://github.com/MirrorNG/MirrorNG_Websocket/issues/247)) ([b786646](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b786646f1859bb0e1836460c6319a507e1cc31aa))
* spawning invalid object now gives exception ([e2fc829](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e2fc8292400aae8b3b8b972ff5824b8d9cdd6b88))
* support sending and receiving ArraySegment<byte> ([#898](https://github.com/MirrorNG/MirrorNG_Websocket/issues/898)) ([e5eecbf](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e5eecbff729f426e0de387f86fed70dc1c28b35a))
* support writing and reading array segments ([#918](https://github.com/MirrorNG/MirrorNG_Websocket/issues/918)) ([f9ff443](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f9ff44399ba42c3c7dbc4d4f2615ee4837aa6133))
* supports scriptable objects ([4b8f819](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4b8f8192123fe0b79ea71f2255a4bbac404c88b1))
* supports scriptable objects ([#1471](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1471)) ([0f10c72](https://github.com/MirrorNG/MirrorNG_Websocket/commit/0f10c72744864ac55d2e1aa96ba8d7713c77d9e7))
* Sync Events no longer need Event prefix ([#2087](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2087)) ([ed40c2d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ed40c2d210f174f1ed50b1e929e4fb161414f228))
* SyncDictionary can now be used for any IDictionary ([#703](https://github.com/MirrorNG/MirrorNG_Websocket/issues/703)) ([2683572](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2683572fb43cbe22c58d9994007ffebaf001fb4a))
* SyncList now supports any IList implementation ([#704](https://github.com/MirrorNG/MirrorNG_Websocket/issues/704)) ([040bcb4](https://github.com/MirrorNG/MirrorNG_Websocket/commit/040bcb45adbb4d7d2ad47c5c2e0275e7c05a7971))
* SyncList.FindIndex added ([#823](https://github.com/MirrorNG/MirrorNG_Websocket/issues/823)) ([b5ff43a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b5ff43ada3fa1ec39f88dd689117761bbefcdd0a))
* synclists has individual meaningful events ([#109](https://github.com/MirrorNG/MirrorNG_Websocket/issues/109)) ([e326064](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e326064b51e8372726b30d19973df6293c74c376)), closes [#103](https://github.com/MirrorNG/MirrorNG_Websocket/issues/103)
* SyncSet and SyncDictionary now show in inspector ([#1561](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1561)) ([5510711](https://github.com/MirrorNG/MirrorNG_Websocket/commit/55107115c66ea38b75edf4a912b5cc48351128f7))
* SyncSet custom Equality Comparer support ([#1147](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1147)) ([0f95185](https://github.com/MirrorNG/MirrorNG_Websocket/commit/0f951858c553abd34be8544bf717744fae1d35c5))
* SyncToOwner now works with authority ([#1204](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1204)) ([92d0df7](https://github.com/MirrorNG/MirrorNG_Websocket/commit/92d0df7b399027ccd8f5983fc4bc4fea4530badc))
* TargetRpc no longer need Target prefix ([#2085](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2085)) ([d89ac9f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d89ac9fb052c17c2edfdf381aff35f70d23f4f0a))
* telepathy can now receive port from uri ([#1284](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1284)) ([06946cf](https://github.com/MirrorNG/MirrorNG_Websocket/commit/06946cf37fc2ed8660c93394d30632de3edc35db))
* throw exception if assigning incorrect asset id ([#250](https://github.com/MirrorNG/MirrorNG_Websocket/issues/250)) ([7741fb1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7741fb1f11abc8eb2aec8c1a94ac53380ac5a562))
* Time sync is now done per NetworkClient ([b24542f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b24542f62c6a2d0c43588af005f360ed74c619ca))
* transport can provide their preferred scheme ([774a07e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/774a07e1bf26cce964cf14d502b71b43ce4f5cd0))
* Transport can send to multiple connections at once ([#1120](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1120)) ([bc7e116](https://github.com/MirrorNG/MirrorNG_Websocket/commit/bc7e116a6e1e3f1a7dd326109631c8c8d12b2622))
* transports can give server uri ([#113](https://github.com/MirrorNG/MirrorNG_Websocket/issues/113)) ([dc700ec](https://github.com/MirrorNG/MirrorNG_Websocket/commit/dc700ec721cf4ecf6ddd082d88b933c9afffbc67))
* Transports can have multiple uri ([#292](https://github.com/MirrorNG/MirrorNG_Websocket/issues/292)) ([155a29c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/155a29c053421f870241a75427db748fbef08910))
* Transports can tell if they are supported ([#282](https://github.com/MirrorNG/MirrorNG_Websocket/issues/282)) ([890c6b8](https://github.com/MirrorNG/MirrorNG_Websocket/commit/890c6b8808ccbf4f4ffffae8c00a9d897ccac7e4))
* Transports may support any number of schemes ([#291](https://github.com/MirrorNG/MirrorNG_Websocket/issues/291)) ([2af7b9d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2af7b9d19cef3878147eee412adf2b9b32c91147))
* update upm package if tests pass ([#21](https://github.com/MirrorNG/MirrorNG_Websocket/issues/21)) ([7447776](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7447776a3bb47aa1e8f262671d62b48d52591247))
* Use logger framework for NetworkClient ([#1685](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1685)) ([6e92bf5](https://github.com/MirrorNG/MirrorNG_Websocket/commit/6e92bf5616d0d2486ce86497128094c4e33b5a3f))
* Use SortedDictionary for LogSettings ([#1914](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1914)) ([7d4c0a9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7d4c0a9cb6f24fa3c2834b9bf351e30dde88665f))
* user friendly weaver error ([#896](https://github.com/MirrorNG/MirrorNG_Websocket/issues/896)) ([954a3d5](https://github.com/MirrorNG/MirrorNG_Websocket/commit/954a3d594d53adba4fbea25193170760ed810ee8))
* Users may provide custom serializers for any type ([#1153](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1153)) ([9cb309e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9cb309e5bcb01ff3de4781e49d3a4f0a1227891b))
* Weaver can now automatically create Reader/Writer for types in a different assembly ([#1708](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1708)) ([b1644ae](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b1644ae481497d4347f404543c8200d2754617b9)), closes [#1570](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1570)
* websocket can receive port in url ([#1287](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1287)) ([c8ad118](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c8ad118d5065f2570c45914d8c1d6daeac2de7ef))
* Websockets now give client address, fix [#1121](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1121) ([#1125](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1125)) ([c9f317d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c9f317ddee092a59d2de8ad5988bea09a1ca152f))
* **scene:** Add support for scene loading params ([#644](https://github.com/MirrorNG/MirrorNG_Websocket/issues/644)) ([d48a375](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d48a3757dabe072002f93293fe9c7bcb13b1354d))
* **syncvar:** Add SyncDictionary ([#602](https://github.com/MirrorNG/MirrorNG_Websocket/issues/602)) ([7d21bde](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7d21bded9a521e53acc212b11a756d41e1b4218c))
* **telepathy:** Split MaxMessageSize to allow setting a different value for client and server ([#749](https://github.com/MirrorNG/MirrorNG_Websocket/issues/749)) ([f0a8b5d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f0a8b5dea817cf59d961643f409d2347349a1261))
* **websocket:** Re-enable native SSL ([#965](https://github.com/MirrorNG/MirrorNG_Websocket/issues/965)) ([7ed4a9a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7ed4a9a1e0727e067795ef7a9a24c6203f8ceb34))


### Performance Improvements

* Adding buffer for local connection ([#1621](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1621)) ([4d5cee8](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4d5cee893d0104c0070a0b1814c8c84f11f24f18))
* Adding dirty check before update sync var ([#1702](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1702)) ([58219c8](https://github.com/MirrorNG/MirrorNG_Websocket/commit/58219c8f726cd65f8987c9edd747987057967ea4))
* AddPlayerMessage is now a value type ([246a551](https://github.com/MirrorNG/MirrorNG_Websocket/commit/246a551151ea33892aa3bc04faca68c0b755a653))
* allocation free enumerator for syncsets,  fixes [#1171](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1171) ([#1173](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1173)) ([035e630](https://github.com/MirrorNG/MirrorNG_Websocket/commit/035e6307f98e3296f5d0f5c37eea5d4ce9c26fd0))
* allocation free syncdict foreach, fix [#1172](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1172) ([#1174](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1174)) ([1ec8910](https://github.com/MirrorNG/MirrorNG_Websocket/commit/1ec89105758cb6a76c438aa990c1dcfbf0a78af6))
* avoid allocation for error messages ([c669ff1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c669ff155df16a007ee69d703a1f72f2e0e0b919))
* Avoid allocation when reading message payload ([#912](https://github.com/MirrorNG/MirrorNG_Websocket/issues/912)) ([11750a9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/11750a9e7a3f330e508642d1fca51173c3a4d5a8))
* avoid allocation with message structs ([#939](https://github.com/MirrorNG/MirrorNG_Websocket/issues/939)) ([7c7c910](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7c7c910a5e5ce15dc81b1008e4797222abe7fd9a))
* avoid boxing for getting message id ([#1144](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1144)) ([9513842](https://github.com/MirrorNG/MirrorNG_Websocket/commit/95138427f3c6765ba25bccc98968f477c1f8bcda))
* avoid boxing if there is no profiler ([a351879](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a351879f910be15492d498b3cc38e2ea8861d231))
* ClientAuthorityMessage is now a value type ([#991](https://github.com/MirrorNG/MirrorNG_Websocket/issues/991)) ([d071438](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d071438d01080b56065e800c3ddf492c87231ed6))
* Custom IEnumerator for SyncLists to avoid allocations on foreach ([#904](https://github.com/MirrorNG/MirrorNG_Websocket/issues/904)) ([4ffd5a2](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4ffd5a2e06849fc812106f67d5d2b9c3d40a99b9))
* don't varint bytes and shorts ([4867415](https://github.com/MirrorNG/MirrorNG_Websocket/commit/48674151f01c040979e4a9aebbf3f6037f7b2226))
* eliminate boxing with lists ([#901](https://github.com/MirrorNG/MirrorNG_Websocket/issues/901)) ([8f6d4cb](https://github.com/MirrorNG/MirrorNG_Websocket/commit/8f6d4cb22e0417bb0de1cb744e307250298e20f4))
* eliminate small allocation on remote calls ([#907](https://github.com/MirrorNG/MirrorNG_Websocket/issues/907)) ([1c18743](https://github.com/MirrorNG/MirrorNG_Websocket/commit/1c18743788be9d051fa617345e463cf0df6e38d8))
* eliminate string concat during remote method calls ([#908](https://github.com/MirrorNG/MirrorNG_Websocket/issues/908)) ([70a532b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/70a532b5db7cd0c20797b1168d84c6368480450c))
* empty messages are value types now ([145edaa](https://github.com/MirrorNG/MirrorNG_Websocket/commit/145edaa50bd225db9f1442aa7c86bae13daa6388))
* faster NetworkReader pooling ([#1623](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1623)) ([1ae0381](https://github.com/MirrorNG/MirrorNG_Websocket/commit/1ae038172ac7f5e18e0e09b0081f7f42fa0eff7a))
* faster NetworkWriter pooling ([#1620](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1620)) ([4fa43a9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4fa43a947132f89e5348c63e393dd3b80e1fe7e1))
* Increasing Network Writer performance ([#1674](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1674)) ([f057983](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f0579835ca52270de424e81691f12c02022c3909))
* messages should be value types ([#987](https://github.com/MirrorNG/MirrorNG_Websocket/issues/987)) ([633fb19](https://github.com/MirrorNG/MirrorNG_Websocket/commit/633fb19f8d0f29eef2fd96a97c4da32203cb3408))
* MultiplexTransport: avoid Linq allocations that would happen on every packet send because Send calls .ServerActive() each time ([7fe8888](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7fe8888df5a74667914c66c336625309279ff28a))
* NetworkProximityChecker checks Server.connections instead of doing 10k sphere casts for 10k monsters. 2k NetworkTransforms demo is significantly faster. Stable 80fps instead of 500ms freezes in between. ([#1852](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1852)) ([2d89f05](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2d89f059afd9175dd7e6d81a0e2e38c0a28915c8))
* Networkreader nonalloc ([#910](https://github.com/MirrorNG/MirrorNG_Websocket/issues/910)) ([18f035d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/18f035d268d5c84fb6b34d2836b188692cd5a96c))
* objdestroy message is now a value type ([#993](https://github.com/MirrorNG/MirrorNG_Websocket/issues/993)) ([a32c5a9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a32c5a945689285241cadb809b24c2883ac6078c))
* ObjHideMessage is now a value type ([#992](https://github.com/MirrorNG/MirrorNG_Websocket/issues/992)) ([a49d938](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a49d938fbe3c27f7237705dae3b2a2d21114de81))
* OnDeserializeSafely without GC ([#804](https://github.com/MirrorNG/MirrorNG_Websocket/issues/804)) ([27b7e25](https://github.com/MirrorNG/MirrorNG_Websocket/commit/27b7e250a0451ae6a04222a9d035a5b0efdbeb99))
* Optimize interest management ([f1ceb0c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f1ceb0c7a0438d3b7febbccc1ab8fde0a7e2580b))
* Optimize interest management ([#899](https://github.com/MirrorNG/MirrorNG_Websocket/issues/899)) ([ff1a234](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ff1a2346b4b28acef7054f5e460e4b863dec6372))
* Pack small 32 bit negatives efficiently ([480af1a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/480af1aa6c8aca96b67f1532994c5d7d2d8902c5))
* Pack small 64 bit negatives efficiently ([5f1ef4a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5f1ef4ab1f5a895e4537dcb5b928b557487c5e60))
* Recycle argument writer to avoid allocations ([#945](https://github.com/MirrorNG/MirrorNG_Websocket/issues/945)) ([9743216](https://github.com/MirrorNG/MirrorNG_Websocket/commit/97432169ead1e212bff4496ac2f1afe1c7ad2898))
* Reduce enum bandwidth ([#794](https://github.com/MirrorNG/MirrorNG_Websocket/issues/794)) ([97e9ac2](https://github.com/MirrorNG/MirrorNG_Websocket/commit/97e9ac24830b1e0e0aec28c8608ad630ed024f5c))
* remove allocations during syncvar sync ([#946](https://github.com/MirrorNG/MirrorNG_Websocket/issues/946)) ([d2381ce](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d2381ce892968a91405afd52f00a357144817539))
* remove BinaryWriter,  it allocates like crazy ([#929](https://github.com/MirrorNG/MirrorNG_Websocket/issues/929)) ([7b3e82a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7b3e82a1fc4339698583633b00b9ed052780f6ed))
* remove network transform allocation ([9e3ecc1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9e3ecc1cedc5239d30e91bcdcff9841b94e3dec8))
* Remove redundant mask ([#1604](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1604)) ([5d76afb](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5d76afbe29f456a657c9e1cb7c97435242031091))
* remove syncvar boxing ([#927](https://github.com/MirrorNG/MirrorNG_Websocket/issues/927)) ([b2ba589](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b2ba5896fa6b58fa524e6cde1b763ef6f3cba4b3))
* replace isValueType with faster alternative ([#1617](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1617)) ([61163ca](https://github.com/MirrorNG/MirrorNG_Websocket/commit/61163cacb4cb2652aa8632f84be89212674436ff)), closes [/github.com/vis2k/Mirror/issues/1614#issuecomment-605443808](https://github.com//github.com/vis2k/Mirror/issues/1614/issues/issuecomment-605443808)
* return the contents of the writer as an array segment ([#916](https://github.com/MirrorNG/MirrorNG_Websocket/issues/916)) ([ced3690](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ced36906bcb6dca2a1edb439da6b00d0b5d0d09d))
* reuse the network writer used for rpc parameters ([5dafc4d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5dafc4d932584710c4fec62b9bfb52cedd7f02fb))
* rpc messages are now value types ([#997](https://github.com/MirrorNG/MirrorNG_Websocket/issues/997)) ([b5b2f3e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b5b2f3e1eb8c64d54cd322e095c42a224dad0f1a))
* SceneMessage is now a value type ([#989](https://github.com/MirrorNG/MirrorNG_Websocket/issues/989)) ([407b36a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/407b36acb724cbf90737465e9faf4918d0cee345))
* simplify and speed up getting methods in weaver ([c1cfc42](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c1cfc421811e4c12e84cb28677ac68c82575958d))
* spawn with client authority only takes 1 message ([#1206](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1206)) ([3b9414f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3b9414f131450e5f96c621f57d9e061dbda62661))
* SpawnPrefabMessage is now a value type ([a44efd1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a44efd1f92b66cbf7325830463e7e310dabe3fd8))
* SpawnSceneObjectMessage is now a value type ([40c7d97](https://github.com/MirrorNG/MirrorNG_Websocket/commit/40c7d97ed99fe7a478b74d1530b70fbc2ae3cfa9))
* Transports now give ArraySegment<byte> instead of byte[] (based on [#569](https://github.com/MirrorNG/MirrorNG_Websocket/issues/569) and [#846](https://github.com/MirrorNG/MirrorNG_Websocket/issues/846)) ([77bee45](https://github.com/MirrorNG/MirrorNG_Websocket/commit/77bee450b91661e9f3902a30e0749cf6c786020c))
* update vars is now a value type ([#990](https://github.com/MirrorNG/MirrorNG_Websocket/issues/990)) ([f99e71e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f99e71ebdfe2fdf50116270618a5bf0f2b97b748))
* Use 0 for null byte arrays ([#925](https://github.com/MirrorNG/MirrorNG_Websocket/issues/925)) ([21ca49d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/21ca49d1be9a15445baf1f7417d7fc6ec1df1053))
* use 0 for null strings ([#926](https://github.com/MirrorNG/MirrorNG_Websocket/issues/926)) ([7181cd9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7181cd9ca190a5f3eb45ec7878492479db55d9f3))
* use bitshift operations instead of division in varint ([fff765c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/fff765c96be0c61d77ade8f5c12997e709ab3d89))
* use byte[] directly instead of MemoryStream ([#1618](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1618)) ([166b8c9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/166b8c946736447a76c1886c4d1fb036f6e56e20))
* Use continuewith to queue up ssl messages ([#1640](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1640)) ([84b2c8c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/84b2c8cf2671728baecf734487ddaa7fab9943a0))
* Use invokeRepeating instead of Update ([#2066](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2066)) ([264f9b8](https://github.com/MirrorNG/MirrorNG_Websocket/commit/264f9b8f945f0294a8420202abcd0c80e27e6ee6))
* Use NetworkWriterPool in NetworkAnimator ([#1421](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1421)) ([7d472f2](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7d472f21f9a807357df244a3f0ac259dd431661f))
* Use NetworkWriterPool in NetworkTransform ([#1422](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1422)) ([a457845](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a4578458a15e3d2840a49dd029b4c404cadf85a4))
* Use RemoveAt to remove elements from lists ([22b45f7](https://github.com/MirrorNG/MirrorNG_Websocket/commit/22b45f7a11be6f3c09e49a302506b540c1c5adc6))
* use value types for empty messages ([#988](https://github.com/MirrorNG/MirrorNG_Websocket/issues/988)) ([81d915e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/81d915eb7350878f69db2f579355ad1224359194))
* Use WritePackedUInt32 in SyncList ([#688](https://github.com/MirrorNG/MirrorNG_Websocket/issues/688)) ([2db7576](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2db7576bbc163cf53e1b28384972361e3ca4a720))


* remove NetworkConnection.isAuthenticated (#167) ([8a0e0b3](https://github.com/MirrorNG/MirrorNG_Websocket/commit/8a0e0b3af37e8b0c74a8b97f12ec29cf202715ea)), closes [#167](https://github.com/MirrorNG/MirrorNG_Websocket/issues/167)
* Simplify RegisterHandler (#160) ([f4f5167](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f4f516791b8390f0babf8a7aefa19254427d4145)), closes [#160](https://github.com/MirrorNG/MirrorNG_Websocket/issues/160)
* Remove NetworkConnectionToClient (#155) ([bd95cea](https://github.com/MirrorNG/MirrorNG_Websocket/commit/bd95cea4d639753335b21c48781603acd758a9e7)), closes [#155](https://github.com/MirrorNG/MirrorNG_Websocket/issues/155)
* remove room feature for now (#122) ([87dd495](https://github.com/MirrorNG/MirrorNG_Websocket/commit/87dd495a6fca6c85349afd42ba6449d98de1f567)), closes [#122](https://github.com/MirrorNG/MirrorNG_Websocket/issues/122)
* Server Disconnect is now an event not a message (#121) ([82ebd71](https://github.com/MirrorNG/MirrorNG_Websocket/commit/82ebd71456cbd2e819540d961a93814c57735784)), closes [#121](https://github.com/MirrorNG/MirrorNG_Websocket/issues/121)
* remove OnClientStart virtual ([eb5242d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/eb5242d63fa011381e7692470713fd144476454a))
* Move on client stop (#118) ([678e386](https://github.com/MirrorNG/MirrorNG_Websocket/commit/678e3867a9f232e52d2a6cdbfae8140b0e82bd11)), closes [#118](https://github.com/MirrorNG/MirrorNG_Websocket/issues/118)
* merge clientscene and networkclient (#84) ([dee1046](https://github.com/MirrorNG/MirrorNG_Websocket/commit/dee10460325119337401dc4d237dec8bfb9ddb29)), closes [#84](https://github.com/MirrorNG/MirrorNG_Websocket/issues/84)
* removed obsoletes (#1542) ([4faec29](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4faec295593b81a709a57aaf374bb5b080a04538)), closes [#1542](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1542)
* Assign/Remove client authority now throws exception ([7679d3b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7679d3bef369de5245fd301b33e85dbdd74e84cd))
* Removed LLAPI ([b0c936c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b0c936cb7d1a803b7096806a905a4c121e45bcdf))
* Simplify unpacking messages (#65) ([c369da8](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c369da84dc34dbbde68a7b30758a6a14bc2573b1)), closes [#65](https://github.com/MirrorNG/MirrorNG_Websocket/issues/65)
* Remove all compiler defines ([a394345](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a3943459598d30a325fb1e1315b84c0dedf1741c))
* Simplify AddPlayerForConnection (#62) ([fb26755](https://github.com/MirrorNG/MirrorNG_Websocket/commit/fb267557af292e048df248d4f85fff3569ac2963)), closes [#62](https://github.com/MirrorNG/MirrorNG_Websocket/issues/62)
* Renamed localEulerAnglesSensitivity (#1474) ([eee9692](https://github.com/MirrorNG/MirrorNG_Websocket/commit/eee969201d69df1e1ee1f1623b55a78f6003fbb1)), closes [#1474](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1474)
* Rename NetworkServer.localClientActive ([7cd0894](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7cd0894853b97fb804ae15b8a75b75c9d7bc04a7))
* Simplify spawning ([c87a38a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c87a38a4ff0c350901138b90db7fa8e61b1ab7db))
* Merge pull request #650 from vis2k/networkclient_static_2 ([fac0542](https://github.com/MirrorNG/MirrorNG_Websocket/commit/fac05428cc7f49f53d2322a010d61b61349241ef)), closes [#650](https://github.com/MirrorNG/MirrorNG_Websocket/issues/650)


### Reverts

* Revert "Revert "Explain why 10"" ([d727e4f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d727e4fd4b9e811025c7309efeba090e3ac14ccd))
* Revert "Revert "perf: faster NetworkWriter pooling (#1616)"" ([20e9e5d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/20e9e5dab0dfb8a67d11d84152b0580ea5370551)), closes [#1616](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1616)
* Revert "fix: replacing the player does not mean giving up authority (#1254)" ([b8618d3](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b8618d356f0eeb7aa7bde5ea41c56d7a2cdb3373)), closes [#1254](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1254)
* Revert "feat: Add Timeout to NetworkAuthenticator (#1091)" ([12c5a8f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/12c5a8fdc30280b9ad113c3a8116b2d046d3b31f)), closes [#1091](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1091)
* Revert "Remove add component from deprecated components (#1087)" ([9f09c21](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9f09c216807271e5fc89aa441fa95af0b0eaf80c)), closes [#1087](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1087)
* Revert "Inserted blank lines where appropriate" ([913d503](https://github.com/MirrorNG/MirrorNG_Websocket/commit/913d503fdade774e668ceb43d9397b86870d99cd))
* Revert "feat: Custom readers and writers" ([07ef8c9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/07ef8c91c0931628adb589b67893a80145134c15))
* Revert "New Basic Example (#985)" ([35b9919](https://github.com/MirrorNG/MirrorNG_Websocket/commit/35b9919d91a9b942b133426eed0d45733f48cd6b)), closes [#985](https://github.com/MirrorNG/MirrorNG_Websocket/issues/985)
* Revert "fix: reduce allocations at the transport" ([bb128fe](https://github.com/MirrorNG/MirrorNG_Websocket/commit/bb128fe3b5f05becaf7ea0546c9198707d2c76ba))
* Revert "doc: messages can be struct now" ([79f7c81](https://github.com/MirrorNG/MirrorNG_Websocket/commit/79f7c815207e18e35fddf9c2e528178eb88decd9))
* Revert "ClientScene.OnSpawnPrefab and NetworkManager.OnServerAddPlayerInternal: spawn objects with prefab names to avoid unnecessary "(Clone)" suffix from Unity. otherwise we need a name sync component in all games that show the names, e.g. MMOs for all monsters. This way we only need name sync components for objects that actually do change names, e.g. players." because of issue #426 ([82d4cf0](https://github.com/MirrorNG/MirrorNG_Websocket/commit/82d4cf08ff187c002d5ddf04b7b88d72709b3a44)), closes [#426](https://github.com/MirrorNG/MirrorNG_Websocket/issues/426)
* Revert "Source based weaver (#319)" ([9b232b0](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9b232b05517bc215e005a333aafcb92cdb832d60)), closes [#319](https://github.com/MirrorNG/MirrorNG_Websocket/issues/319)
* Revert "Code style and comment typo fix." (#386) ([dc3b767](https://github.com/MirrorNG/MirrorNG_Websocket/commit/dc3b767743309c414b5e88ba3443f82b93dab0e2)), closes [#386](https://github.com/MirrorNG/MirrorNG_Websocket/issues/386)
* Revert "Onserialize improvements (#302)" ([00a3610](https://github.com/MirrorNG/MirrorNG_Websocket/commit/00a36109a0a0ebad860a0f37245a22de3cd05f70)), closes [#302](https://github.com/MirrorNG/MirrorNG_Websocket/issues/302)
* Revert "Documented the attributes." ([9e3dcc7](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9e3dcc7acdded4980b5ccef3a3b3104e9c27d80a))
* Revert "Documented NetworkBehaviour and NetworkIdentity." ([a5cfc81](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a5cfc810dbddb7aabada07c0200d0d52f743a2d6))
* Revert "Documented NetworkManager." ([5bc44a9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5bc44a97398a476139ef4aebcdf024921b8d1f18))
* Revert "Don't generate OnSerialize/OnDeserialize if not needed (#199)" (#217) ([40a3ecc](https://github.com/MirrorNG/MirrorNG_Websocket/commit/40a3ecce083e021adaeb56daf2653fb89a0e08b0)), closes [#199](https://github.com/MirrorNG/MirrorNG_Websocket/issues/199) [#217](https://github.com/MirrorNG/MirrorNG_Websocket/issues/217)
* Revert "Don't require Cmd, Rpc and Target prefixes (#127)" ([96992c3](https://github.com/MirrorNG/MirrorNG_Websocket/commit/96992c35bce04c07c4cbdd29c7ea534dc096fdc7)), closes [#127](https://github.com/MirrorNG/MirrorNG_Websocket/issues/127)


### BREAKING CHANGES

* rename AsyncMultiplexTransport -> MultiplexTransport
* rename AsyncFallbackTransport -> FallbackTransport
* rename AsyncWsTransport -> WsTransport
* [LocalPlayerCallback] is now [LocalPlayer(error = false)]

* Local Player guard

Co-authored-by: Paul Pacheco <paul.pacheco@aa.com>
* [ClientCallback] is now [Client(error = false)]
* [HasAuthorityCallback] is now [HasAuthority(error = false)]

* fix test

Co-authored-by: Paul Pacheco <paul.pacheco@aa.com>
* [ServerCallback] is now [Server(error = false)]

* fixed weaver test

* Remove unused code

* fix comment

* document replacement of ServerCallback

* No need to be serializable

* Exception should be serializable?

* Fix code smell

* No need to implement interface,  parent does

Co-authored-by: Paul Pacheco <paul.pacheco@aa.com>
* Renamed [Command] to [ServerRpc]
* NetworkManager no longer handles scene changes
* Remove isAuthenticated

* Fix typo

* Fix smells

* Remove smells
* NetworkConneciton.RegisterHandler only needs message class
* NetworkConnectionToClient and networkConnectionToServer are gone
* connecition Id is gone
* websocket transport does not work,  needs to be replaced.
* NetworkManager no longer has OnServerStart virtual
* NetworkManager no longer spawns the player.  You need to add PlayerSpawner component if you want that behavior
* You will need to reassign your scenes after upgrade

* Automatically fix properties that were using name

If you open a NetworkManager or other gameobject that uses a scene name
it now gets converted to scene path by the SceneDrawer

* Use get scene by name

* Scene can never be null

* Update Assets/Mirror/Examples/AdditiveScenes/Scenes/MainScene.unity

* Issue warning if we drop the scene

* Issue error if scene is lost

* Add suggestion on how to fix the error

* Keep backwards compatibility, check for scene name

* cache the active scene

* Update Assets/Mirror/Editor/SceneDrawer.cs

Co-Authored-By: James Frowen <jamesfrowendev@gmail.com>

* GetSceneByName only works if scene is loaded

* Remove unused using

Co-authored-by: James Frowen <jamesfrowendev@gmail.com>
* Room feature and example are gone
* offline/online scenes are gone
* OnServerDisconnect is gone
* Removed OnStartClient virtual,  use event from NetworkClient instead
* OnStopClient virtual is replaced by event in Client
* SyncDictionary callback has been replaced
* callback signature changed in SyncSet
* Sync lists no longer have a Callback event with an operation enum
* NetworkBehavior no longer has virtuals for lifecycle events
* ClientScene is gone
* removed obsoletes
* NetworkTime.Time is no longer static
* observers is now a set of connections, not a dictionary
* cannot pass GameObjects and NetworkIdentities anymore.
Will be restored in the future.
* StartClient now receives the server ip
* NetworkManager no longer has NetworkAddress
* Assign/Remove client authority throws exception instead of returning boolean
* Removed LLAPITransport
* MessagePacker.UnpackMessage replaced by UnpackId
* removed compilation defines,  use upm version defines instead
* AddPlayerForConnection no longer receives the client

* fix compilatio errors

* fix build errors
* ClientConnect replaced with ClientConnectAsync
that can be awaited

* fix: TCP transport for async compliance

* use async connect

* Ignore telepathy tests until they are fixed

* It is ok to interrupt sockets

* Remove some warnings

* Remove some warnings

* Remove some warnings

* Remove some warnings

* Remove some warnings

* Remove some warnings

* Remove some warnings
* localEulerAnglesSensitivity renamed to localRotationSensitivity
* Make the server uri method mandatory in transports

Co-authored-by: MrGadget <chris@clevertech.net>
* rename localClientActive to LocalClientActive
* Spawn no longer receives NetworkClient
* Remove obsolete OnServerAddPlayer

Any person that overrides this method has a broken game.  These methods are never called anywhere.

The user gets a warning because they are overriding an obsolete method,  which might get ignored if they have lots of other warnings.   They would run their game and their game would not work at all.  No errors.

By removing these methods, users that override these methods will get a compile time error instead.  So they cannot ignore this error and they will fix it.

* Method is no longer available in NetworkLobbyManager
* Make NetworkClient Great Again!

# [1.1.0](https://github.com/MirrorNG/MirrorNG_Websocket/compare/1.0.0-master...1.1.0-master) (2020-07-16)


### Features

* add basic example with websocket ([b85296e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b85296eaadbcfb054153f77322f4f17ccc23bba7))
* Add Multiplex example with websocket ([6937f59](https://github.com/MirrorNG/MirrorNG_Websocket/commit/6937f5939de07679bb0738c0e3532d32856fb186))

# 1.0.0 (2020-07-16)


### breaking

* AsyncFallbackTransport -> FallbackTransport ([f8f643a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f8f643a6245777279de31dc8997a7ea84328533e))
* AsyncMultiplexTransport -> MultiplexTransport ([832b7f9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/832b7f9528595e45769790c4be4fd94e873c96f4))
* Rename [Command] to [ServerRpc] ([#271](https://github.com/MirrorNG/MirrorNG_Websocket/issues/271)) ([fff7459](https://github.com/MirrorNG/MirrorNG_Websocket/commit/fff7459801fc637c641757c516f85b4d685e0ad1))
* rename AsyncWsTransport -> WsTransport ([9c394bc](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9c394bc96192a50ad273371b66c9289d75402dc6))
* Transports can now provide their Uri ([#1454](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1454)) ([b916064](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b916064856cf78f1c257f0de0ffe8c9c1ab28ce7)), closes [#38](https://github.com/MirrorNG/MirrorNG_Websocket/issues/38)


### Bug Fixes

* (again) Telepathy updated to latest version (Send SocketExceptions now disconnect the player too) ([46eddc0](https://github.com/MirrorNG/MirrorNG_Websocket/commit/46eddc01ec104f98701e5552a66728ae48d0720f))
* [#1241](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1241) - Telepathy updated to latest version. All tests are passing again. Thread.Interrupt was replaced by Abort+Join. ([228b32e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/228b32e1da8e407e1d63044beca0fd179f0835b4))
* [#1278](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1278) - only call initial state SyncVar hooks on clients if the SyncVar value is different from the default one. ([#1414](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1414)) ([a3ffd12](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a3ffd1264c2ed2780e6e86ce83077fa756c01154))
* [#1359](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1359). Revert "Destroy objects owned by this connection when disconnecting ([#1179](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1179))" ([4cc4279](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4cc4279d7ddeaf61fe300b3dc420143e63942f1f))
* [#1380](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1380) - NetworkConnection.clientOwnedObjects changed from uint HashSet to NetworkIdentity HashSet for ease of use and to fix a bug where DestroyOwnedObjects wouldn't find a netId anymore in some cases. ([a71ecdb](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a71ecdba4a020f9f4648b8275ec9d17b19aff55f))
* [#1515](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1515) - StopHost now invokes OnServerDisconnected for the host client too ([#1601](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1601)) ([678ac68](https://github.com/MirrorNG/MirrorNG_Websocket/commit/678ac68b58798816658d29be649bdaf18ad70794))
* [#1593](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1593) - NetworkRoomManager.ServerChangeScene doesn't destroy the world player before replacing the connection. otherwise ReplacePlayerForConnection removes authority form a destroyed object, causing all kidns of errors. The call wasn't actually needed. ([#1594](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1594)) ([347cb53](https://github.com/MirrorNG/MirrorNG_Websocket/commit/347cb5374d0cba72762e893645f076d3161aa0c5))
* [#1599](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1599) - NetworkManager HUD calls StopHost/Server/Client depending on state. It does not call StopHost in all cases. ([#1600](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1600)) ([8c6ae0f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/8c6ae0f8b4fdafbc3abd194c081c75ee75fcfe51))
* [#1659](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1659) Telepathy LateUpdate processes a limited amount of messages per tick to avoid deadlocks ([#1830](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1830)) ([d3dccd7](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d3dccd7a25e4b9171ac04e43a05954b56caefd4b))
* [#573](https://github.com/MirrorNG/MirrorNG_Websocket/issues/573) (part 1) NetworkScenePostProcess handles NetworkIdentities of all scenes except DontDestroyOnLoad. this way it works for additively loaded scenes too. ([c1af84e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c1af84e6bf61ff919607c66affc4a1bd0dc3fb26))
* [#573](https://github.com/MirrorNG/MirrorNG_Websocket/issues/573) (part 2) NetworkManager detects additive scene loads and respawns objects on server/client again ([e521a20](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e521a200523b25a874a3cbc743d2a9d98a88b238))
* [#573](https://github.com/MirrorNG/MirrorNG_Websocket/issues/573) NullReferenceException because destroyed NetworkIdentities were never removed from sceneIds dict ([a2d6317](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a2d6317642a24571a63bbeade5fe8898f56c1c3e))
* [#609](https://github.com/MirrorNG/MirrorNG_Websocket/issues/609) by spawning observers in NetworkServer.AddPlayerForConnection after setting the controller. There is no point in trying to spawn with a null controller in SetReady, because by definition no one can observer something that is null. ([#623](https://github.com/MirrorNG/MirrorNG_Websocket/issues/623)) ([5c00577](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5c00577746f83eadd948383dd478360e96634ea4))
* [#640](https://github.com/MirrorNG/MirrorNG_Websocket/issues/640) InternalReplacePlayerForConnection calls SpawnObserversForConnection now too ([bdf12c8](https://github.com/MirrorNG/MirrorNG_Websocket/commit/bdf12c85d01b20f2a0edc0767454401a6c5a1aad))
* [#651](https://github.com/MirrorNG/MirrorNG_Websocket/issues/651) GetSceneAt assumes default scene ([#654](https://github.com/MirrorNG/MirrorNG_Websocket/issues/654)) ([65eaba1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/65eaba1fe059db159b5fdb1427dc8b783f5720e0))
* [#652](https://github.com/MirrorNG/MirrorNG_Websocket/issues/652) OnPostProcessScene includes disabled NetworkIdentities in scene ([ee2ace8](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ee2ace8e428d67309dc219109be5853b1a9b67df))
* [#679](https://github.com/MirrorNG/MirrorNG_Websocket/issues/679) package for unity ([4a6a4df](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4a6a4df61bc65c2065cb1150cd05e15528db6b66))
* [#679](https://github.com/MirrorNG/MirrorNG_Websocket/issues/679) unity package ([9895647](https://github.com/MirrorNG/MirrorNG_Websocket/commit/98956472969ba8ae1c66d255f1094140aeb275f0))
* [#692](https://github.com/MirrorNG/MirrorNG_Websocket/issues/692) by always adding connectionToClient when rebuilding observers ([ab44ac8](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ab44ac8f8bad4749e300ba8c2db4593fcff5474f))
* [#718](https://github.com/MirrorNG/MirrorNG_Websocket/issues/718) remove Tests folder from unitypackage ([#827](https://github.com/MirrorNG/MirrorNG_Websocket/issues/827)) ([7e487af](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7e487afe512de9dc8a0d699693884cbfc9c7be7e))
* [#723](https://github.com/MirrorNG/MirrorNG_Websocket/issues/723) - NetworkTransform teleport works properly now ([fd7dc5e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/fd7dc5e226a76b27250fb503a98f23eb579387f8))
* [#791](https://github.com/MirrorNG/MirrorNG_Websocket/issues/791) corrected assembly paths passed to weaver ([#803](https://github.com/MirrorNG/MirrorNG_Websocket/issues/803)) ([3ba546e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3ba546e133dae6dd2762d7c4f719f61e90554473))
* [#791](https://github.com/MirrorNG/MirrorNG_Websocket/issues/791) stack overflow in the weaver ([#792](https://github.com/MirrorNG/MirrorNG_Websocket/issues/792)) ([7b57830](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7b57830e6c8e3b9abf470cf1029eb2e4aba914ee))
* [#840](https://github.com/MirrorNG/MirrorNG_Websocket/issues/840) by allowing Mirror to respect the forceHidden flag ([#893](https://github.com/MirrorNG/MirrorNG_Websocket/issues/893)) ([3ec3d02](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3ec3d023621e121aed302222fdb6e35ed5ca92b2))
* add Changelog metadata fix [#31](https://github.com/MirrorNG/MirrorNG_Websocket/issues/31) ([c67de22](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c67de2216aa331de10bba2e09ea3f77e6b1caa3c))
* add client only test for FinishLoadScene ([#262](https://github.com/MirrorNG/MirrorNG_Websocket/issues/262)) ([50e7fa6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/50e7fa6e287fee09afbe36a51575f41c4bd50736))
* Add missing channelId to NetworkConnectionToClient.Send calls ([#1509](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1509)) ([b8bcd9a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b8bcd9ad25895eee940a3daaf6fe7ed82eaf76ac))
* add tests for NetworkTransform and NetworkRigidbody ([#273](https://github.com/MirrorNG/MirrorNG_Websocket/issues/273)) ([e9621dd](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e9621ddebd50637680fad8fe743c7c99afea3f84))
* Add the transport first so NetworkManager doesn't add Telepathy in OnValidate ([bdec276](https://github.com/MirrorNG/MirrorNG_Websocket/commit/bdec2762821dc657e8450b576422fcf1f0f69cdf))
* Added ClientOnly check ([fb927f8](https://github.com/MirrorNG/MirrorNG_Websocket/commit/fb927f814110327867821dac8b0d69ca4251d4f6))
* Added LogFilter.Debug check in a few places ([#1575](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1575)) ([3156504](https://github.com/MirrorNG/MirrorNG_Websocket/commit/31565042708ec768fcaafe9986968d095a3a1419))
* added new read/write symbol params ([#806](https://github.com/MirrorNG/MirrorNG_Websocket/issues/806)) ([3a50ca6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3a50ca6352761b47464d0bc7721aa6556d664661))
* Added WriteBytesAndSize tests, and fixed the function to be pedantic. ([#773](https://github.com/MirrorNG/MirrorNG_Websocket/issues/773)) ([72e4e55](https://github.com/MirrorNG/MirrorNG_Websocket/commit/72e4e55778edc0acc4ef3546f69c984f0f392867))
* Adding warning when adding handler with RegisterSpawnHandler if assetid already exists ([#1819](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1819)) ([7f26329](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7f26329e2db9d00da04bed40399af053436218bd))
* Adding warning when adding prefab with RegisterPrefab if assetid already exists ([#1828](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1828)) ([9f59e0c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9f59e0c439707d66409a617b8f209187856eaf5f))
* addingNetwork rigidbody icon and AddComponentMenu attribute ([#2051](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2051)) ([ab1b92f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ab1b92f74b56787feb7c6fde87c0b9838b8d9d0f))
* Additive scene can respawn objects safely ([#1270](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1270)) ([8899d20](https://github.com/MirrorNG/MirrorNG_Websocket/commit/8899d207127be86a01cb859d0539c7927ebc2f67))
* additive scene example ([9fa0169](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9fa016957f487526ab44d443aabfe58fcc69518a))
* Additive Scene Example was missing Player Auth on movement. ([#234](https://github.com/MirrorNG/MirrorNG_Websocket/issues/234)) ([09bbd68](https://github.com/MirrorNG/MirrorNG_Websocket/commit/09bbd686e6c294f24412b35785cfa7a5aa47b5f2))
* additive scene player movement is client authoritative ([e683a92](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e683a92b081c989314c11e48fb21ee0096465797))
* AdditiveSceneExample missing comp and assignments ([#267](https://github.com/MirrorNG/MirrorNG_Websocket/issues/267)) ([ab394b8](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ab394b8f7e823b8c3882de35eaa54c05fbd9316e))
* Allow sync objects to be re-used ([#1744](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1744)) ([58c89a3](https://github.com/MirrorNG/MirrorNG_Websocket/commit/58c89a3d32daedc9b6670ed0b5eb1f8753c902e2)), closes [#1714](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1714)
* Allowing overrides for virtual commands to call base method ([#1944](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1944)) ([b92da91](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b92da91d7a04f41098615ff2e2a35cf7ff479201))
* ArraySegment<byte> work in Messages ([#919](https://github.com/MirrorNG/MirrorNG_Websocket/issues/919)) ([981ba7c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/981ba7c2b3a64ebd9e1405e5182daa030886d792))
* assign spawn locations and fix null refs in example ([#242](https://github.com/MirrorNG/MirrorNG_Websocket/issues/242)) ([3adf343](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3adf3438578ff304f1216022aae8e043c52cd71d))
* AsyncTcp now exits normally when client disconnects ([#141](https://github.com/MirrorNG/MirrorNG_Websocket/issues/141)) ([8896c4a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/8896c4afa2f937839a54dc71fbe578b9c636f393))
* attributes causing a NRE ([#69](https://github.com/MirrorNG/MirrorNG_Websocket/issues/69)) ([fc99c67](https://github.com/MirrorNG/MirrorNG_Websocket/commit/fc99c67712564e2d983674b37858591903294f1a))
* auto reference mirrorng assembly ([93f8688](https://github.com/MirrorNG/MirrorNG_Websocket/commit/93f8688b39822bb30ed595ca36f44a8a556bec85))
* Avoid FindObjectOfType when not needed ([#66](https://github.com/MirrorNG/MirrorNG_Websocket/issues/66)) ([e2a4afd](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e2a4afd0b9ca8dea720acb9c558efca210bd8e71))
* better error for Command, ClientRpc and TargetRpc marked as abstract ([#1947](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1947)) ([62257d8](https://github.com/MirrorNG/MirrorNG_Websocket/commit/62257d8c4fc307ba3e23fbd01dcc950515c31e79))
* Better errors when trying to replace existing assetid ([#1827](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1827)) ([822b041](https://github.com/MirrorNG/MirrorNG_Websocket/commit/822b04155def9859b24900c6e55a4253f85ebb3f))
* build in IL2CPP ([#1524](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1524)) ([59faa81](https://github.com/MirrorNG/MirrorNG_Websocket/commit/59faa819262a166024b16d854e410c7e51763e6a)), closes [#1519](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1519) [#1520](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1520)
* call callback after update dictionary in host ([#1476](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1476)) ([1736bb0](https://github.com/MirrorNG/MirrorNG_Websocket/commit/1736bb0c42c0d2ad341e31a645658722de3bfe07))
* Call hooks when initializing objects OnStartServer on host ([#1249](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1249)) ([7aa7815](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7aa7815754bb3be1071884d6583076badc7cae59))
* call Obsoleted OnStartClient ([#681](https://github.com/MirrorNG/MirrorNG_Websocket/issues/681)) ([8dea50e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/8dea50ed18ca45e72cc5e5addf1cc28c7ab08746))
* call OnStartClient only once in room ([#1264](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1264)) ([4d373c5](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4d373c5071c45201146333f40d3fbc5d1fa8ec26))
* call the virtual OnRoomServerDisconnect before the base ([e6881ef](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e6881ef007f199efca3c326ead258f0c350ffb47))
* calling base method when the first base class did not have the virtual method ([#2014](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2014)) ([4af72c3](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4af72c3a63e72dac6b3bab193dc58bfa3c44a975))
* calling Connect and Authenticate handler twice ([#102](https://github.com/MirrorNG/MirrorNG_Websocket/issues/102)) ([515f5a1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/515f5a15cd5be984f8cb4f94d3be0a0ac919eb63))
* calling syncvar hook when not connected yet ([#77](https://github.com/MirrorNG/MirrorNG_Websocket/issues/77)) ([e64727b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e64727b74bcbb1adfcd8f5efbf96066443254dff))
* changing namespace to match folder name ([#2037](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2037)) ([e36449c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e36449cb22d8a2dede0133cf229bc12885c36bdb))
* chat example ([e6e10a7](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e6e10a7108bc01e3bd0c208734c97c945003ff86))
* chat example works ([0609d50](https://github.com/MirrorNG/MirrorNG_Websocket/commit/0609d50d9b93afd3b42d97ddcd00d32e8aaa0db5))
* check event prefix ([7417b68](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7417b6867175f0a54db56efc4387d2d24b0b37dd))
* Check SceneManager GetSceneByName and GetSceneByPath ([#1684](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1684)) ([e7cfd5a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e7cfd5a498c7359636cd109fe586fce1771bada2))
* Clean up roomSlots on clients in NetworkRoomPlayer ([5032ceb](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5032ceb00035679e0b80f59e91131cdfa8e0b1bb))
* Cleaning up network objects when server stops ([#1864](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1864)) ([4c25122](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4c25122958978557173ec37ca400c47b2d8e834f))
* cleanup the server even after error ([#255](https://github.com/MirrorNG/MirrorNG_Websocket/issues/255)) ([7bd015e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7bd015eac1b77f0ad5974abb5c4c87a5d3da7b6d))
* clear all message handlers on Shutdown ([#1829](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1829)) ([a6ab352](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a6ab3527acb9af8f6a68f0151e5231e4ee1a98e9))
* client being disconnected twice ([#132](https://github.com/MirrorNG/MirrorNG_Websocket/issues/132)) ([36bb3a2](https://github.com/MirrorNG/MirrorNG_Websocket/commit/36bb3a2418bcf41fd63d1fc79e8a5173e4b0bc51))
* client disconnected on server event never raised ([#133](https://github.com/MirrorNG/MirrorNG_Websocket/issues/133)) ([9d9efa0](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9d9efa0e31cbea4d90d7408ae6b3742151b49a21))
* ClientRpc methods now work accross assemblies ([#1129](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1129)) ([13dbcb9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/13dbcb9f35d64285258e748ca1fd5c4daac97a16)), closes [#1128](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1128)
* Cmds can be called from child classes in other assemblies ([d8a98d8](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d8a98d8d996aeded693223b00b90f2eea5084c11)), closes [#1108](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1108)
* code generation works with il2cpp again ([#1056](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1056)) ([8738562](https://github.com/MirrorNG/MirrorNG_Websocket/commit/87385628f0836109fb009b1f912575c5c8145005))
* code smell rename Ready ([#256](https://github.com/MirrorNG/MirrorNG_Websocket/issues/256)) ([6d92d14](https://github.com/MirrorNG/MirrorNG_Websocket/commit/6d92d1482cdd31fa663f7475f103476c65b7d875))
* Command and Rpc debugging information ([#1551](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1551)) ([658847b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/658847b096571eb7cf14e824ea76359576121e63)), closes [#1550](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1550)
* comment punctuation ([4d827cd](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4d827cd9f60e4fb7cd6524d78ca26ea1d88a1eff))
* compilation error ([df7baa4](https://github.com/MirrorNG/MirrorNG_Websocket/commit/df7baa4db0d347ee69c17bad9f9e56ccefb54fab))
* compilation error ([dc74256](https://github.com/MirrorNG/MirrorNG_Websocket/commit/dc74256fc380974ad6df59b5d1dee3884b879bd7))
* compilation error on standalone build ([bb70bf9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/bb70bf963459be02a79c2c40cb7dfb8f10d2b92d))
* compilation issue after merge from mirror ([daf07be](https://github.com/MirrorNG/MirrorNG_Websocket/commit/daf07bea83c9925bd780e23de53dd50604e8a999))
* compilation issues ([22bf925](https://github.com/MirrorNG/MirrorNG_Websocket/commit/22bf925f1ebf018b9ea33df22294fb9205574fa5))
* comply with MIT license in upm package ([b879bef](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b879bef4295e48c19d96a1d45536a11ea47380f3))
* Decouple ChatWindow from player ([#1429](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1429)) ([42a2f9b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/42a2f9b853667ef9485a1d4a31979fcf1153c0d7))
* Default port is 7777 ([960c39d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/960c39da90db156cb58d4765695664f0c084b39a))
* destroy owned objects ([#1352](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1352)) ([d7a58d2](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d7a58d25d4aa79d31dfc3fadfa4f68a5fdb895e6)), closes [#1346](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1346) [#1206](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1206) [#1351](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1351)
* Destroyed NetMan due to singleton collision must not continue. ([#1636](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1636)) ([d2a58a4](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d2a58a4c251c97cdb38c88c9a381496b3078adf8))
* disconnect even if there is an exception ([#152](https://github.com/MirrorNG/MirrorNG_Websocket/issues/152)) ([2eb9de6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2eb9de6b470579b6de75853ba161b3e7a36de698))
* disconnect properly from the server ([c89bb51](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c89bb513e536f256e55862b723487bb21281572e))
* disconnect transport without domain reload ([20785b7](https://github.com/MirrorNG/MirrorNG_Websocket/commit/20785b740e21fb22834cd01d7d628e127df6b80d))
* do not accumulate changes if there are no observers fixes [#963](https://github.com/MirrorNG/MirrorNG_Websocket/issues/963) ([#964](https://github.com/MirrorNG/MirrorNG_Websocket/issues/964)) ([64a0468](https://github.com/MirrorNG/MirrorNG_Websocket/commit/64a046803ada79f7602f6e6fda21d821909fbc98))
* Do not call InternalAddPlayer twice ([#1246](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1246)) ([7119dd1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7119dd15f8e90e6d6bc929a9e4633082615d0023))
* don't call hook in host if no change,  fixes [#1142](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1142) ([#1143](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1143)) ([d8ce80f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d8ce80fe0edb243a71d35bdae657805b18a8a85e))
* don't call OnStartLocalPlayer twice ([#1263](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1263)) ([c753089](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c7530894788bb843b0f424e8f25029efce72d8ca))
* Don't call RegisterClientMessages every scene change ([#1865](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1865)) ([05c119f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/05c119f505390094c8f33e11568d40117360c49e))
* Don't call RegisterClientMessages twice ([#1842](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1842)) ([2a08aac](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2a08aac7cb8887934eb7eb8c232ce07976defe35))
* don't convert null arrays to empty array ([#913](https://github.com/MirrorNG/MirrorNG_Websocket/issues/913)) ([dd758ca](https://github.com/MirrorNG/MirrorNG_Websocket/commit/dd758cac0578629e351bf60d25733d788bd0f668))
* don't crash when stopping the client ([f584388](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f584388a16e746ac5c3000123a02a5c77387765e))
* Don't destroy the player twice ([#1709](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1709)) ([cbc2a47](https://github.com/MirrorNG/MirrorNG_Websocket/commit/cbc2a4772921e01db17033075fa9f7d8cb7e6faf))
* Don't disconnect host ([#608](https://github.com/MirrorNG/MirrorNG_Websocket/issues/608)) ([c1707e5](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c1707e5917c4058a9641376d028f5feff51128cc))
* Don't give host player authority by default ([#1158](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1158)) ([1fc1ed2](https://github.com/MirrorNG/MirrorNG_Websocket/commit/1fc1ed27081413e48a7898fc185cb238ed0074dc))
* Don't increment counter in Awake ([#971](https://github.com/MirrorNG/MirrorNG_Websocket/issues/971)) ([45b7118](https://github.com/MirrorNG/MirrorNG_Websocket/commit/45b711804b1159e390910227796f312f74351025))
* don't report error when stopping the server ([c965d4b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c965d4b0ff32288ebe4e5c63a43e32559203deb1))
* Don't set asset id for scene objects ([7e40232](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7e4023246bc2e6a11909a7c3730ae05ee56d1369))
* Don't set framerate in host mode ([4644bc4](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4644bc4b7730d4aefae833fb59264230026bb4d0))
* Don't throw exception getting address ([7df3ce3](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7df3ce37d1a23b8137119015276436a741b7cd9d))
* don't use obsolete method ([12437ba](https://github.com/MirrorNG/MirrorNG_Websocket/commit/12437ba9c2ccc72998f2dd895b888d8eaa66e7a6))
* Draw SyncVar label for Unity objects inline  ([#1291](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1291)) ([a0425e4](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a0425e4e84cb08c3fd8d7e7fe07a230579d0c0c7))
* Dummy file for SyncListStructProcessor.cs ([#798](https://github.com/MirrorNG/MirrorNG_Websocket/issues/798)) ([75e4f15](https://github.com/MirrorNG/MirrorNG_Websocket/commit/75e4f159e516f8f3b04b6f1a2c77898de8c7c7b5))
* Eliminate NetworkAnimator SetTrigger double firing on Host ([#1723](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1723)) ([e5b728f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e5b728fed515ab679ad1e4581035d32f6c187a98))
* empty scene name isn't considered as empty ([ec3a939](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ec3a93945b5b52a77fd745b39e1e821db721768d))
* error when there are no network behaviors ([#1303](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1303)) ([dbe0643](https://github.com/MirrorNG/MirrorNG_Websocket/commit/dbe064393a6573bcb213b628ec53b547d04891cc))
* error with missing assemblies ([#1052](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1052)) ([00eb23a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/00eb23aa01210860b9c8ab253929563f695714d7)), closes [#1051](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1051)
* examples now work with prefabs in NC ([df4149b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/df4149b8fea9f174742d20f600ef5261058e5300))
* examples run in background ([#233](https://github.com/MirrorNG/MirrorNG_Websocket/issues/233)) ([4755650](https://github.com/MirrorNG/MirrorNG_Websocket/commit/47556500eed7c0e2719e41c0e996925ddf1799bb))
* Fallback and Multiplex now disable their transports when they are disabled  ([#2048](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2048)) ([61d44b2](https://github.com/MirrorNG/MirrorNG_Websocket/commit/61d44b2d80c9616f784e855131ba6d1ee8a30136))
* FinishLoadSceneHost calls FinishStart host which now calls StartHostClient AFTER server online scene was loaded. Previously there was a race condition where StartHostClient was called immediately in StartHost, before the scene change even finished. This was still from UNET. ([df9c29a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/df9c29a6b3f9d0c8adbaff5a500e54abddb303b3))
* first connection id = 1 ([#60](https://github.com/MirrorNG/MirrorNG_Websocket/issues/60)) ([891dab9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/891dab92d065821ca46b47ef2d3eb27124058d74))
* fix adding and saving Components ([2de7ecd](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2de7ecd93029bf5fd2fbb04ad4e47936cbb802cc))
* Fix error scene error message in host mode ([838d4f0](https://github.com/MirrorNG/MirrorNG_Websocket/commit/838d4f019f60e202b3795a01e4297c2d3efe6bca))
* fix release pipeline ([2a3db0b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2a3db0b398cd641c3e1ba65a32b34822e9c9169f))
* Fix Room Slots for clients ([#1439](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1439)) ([268753c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/268753c3bd0a9c0695d8d4510a129685be364a11))
* Fixed Capitalization ([c45deb8](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c45deb808e8e01a7b697e703be783aea2799d4d1))
* Fixed ClienRpc typos ([e946c79](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e946c79194dd9618992a4136daed4b79f60671a2))
* Fixed NetworkRoomManager Template ([1662c5a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/1662c5a139363dbe61784bb90ae6544ec74478c3))
* Fixed toc link ([3a0c7fb](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3a0c7fb1ecd9d8715e797a7665ab9a6a7cb19e2a))
* Fixing ClientScene UnregisterPrefab ([#1815](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1815)) ([9270765](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9270765bebf45c34a466694473b43c6d802b99d9))
* Fixing SyncVars not serializing when OnSerialize is overridden ([#1671](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1671)) ([c66c5a6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c66c5a6dcc6837c840e6a51435b88fde10322297))
* folders for meta files no longer in the codebase ([#237](https://github.com/MirrorNG/MirrorNG_Websocket/issues/237)) ([192fd16](https://github.com/MirrorNG/MirrorNG_Websocket/commit/192fd1645986c515a804a01e0707c78241882676))
* hasAuthority is now visible in all overrides ([#1251](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1251)) ([2f19c7c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2f19c7ca8961e9d99794e6053abfa88263dea89d)), closes [#1250](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1250)
* headless build ([7864e8d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7864e8d6f4a0952ef3114daac11842e4ee0a7a58))
* headless build ([ab47a45](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ab47a45d08f4e9a82a5cd26f913f4871d46dd484))
* hooks in host mode can call each other ([#1017](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1017)) ([f27fd0b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f27fd0bdc570ec3ceeef433eb4991beb487d2ddb))
* Host Player Ready Race Condition ([#1498](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1498)) ([4c4a52b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4c4a52bff95e7c56f065409b1399955813f3e145))
* If socket is undefined it will return false. See [#1486](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1486) ([#2017](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2017)) ([4ffff19](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4ffff192a69108b993cf963cfdece47b14ffdbf2))
* Improved error checking for ClientScene.RegisterPrefab ([#1823](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1823)) ([a0aa4f9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a0aa4f9c1425d4eca3fe08cd2d87361f092ded6f))
* Improved error checking for ClientScene.RegisterPrefab with handler ([#1841](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1841)) ([54071da](https://github.com/MirrorNG/MirrorNG_Websocket/commit/54071da3afb18d6289de5d0e41dc248e21088641))
* invalid scene id in 2019.1 by ignoring prefabs in NetworkScenePostProcess ([203a823](https://github.com/MirrorNG/MirrorNG_Websocket/commit/203a823b19b6e31a50cd193a7bd58c33a73960f2))
* Invoke server.Disconnected before identity is removed for its conn ([#165](https://github.com/MirrorNG/MirrorNG_Websocket/issues/165)) ([b749c4b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b749c4ba126266a1799059f7fb407b6bcaa2bbd9))
* isClient now reports true onStartServer in host mode ([#1252](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1252)) ([d00c95b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d00c95bb55eedceb4f0811de54604c960c9352fe))
* isLocalPlayer is true during OnStartClient for Player ([#1255](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1255)) ([fb26d00](https://github.com/MirrorNG/MirrorNG_Websocket/commit/fb26d0023f2ecfcec710d365f23a19036e3f87b2)), closes [#1250](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1250)
* isLocalPlayer works in host mode onStartServer ([#1253](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1253)) ([9acde20](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9acde20b0a4237936fc028747551204208ac9677)), closes [#1250](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1250)
* it is not safe to modify this outside this class ([bc7a961](https://github.com/MirrorNG/MirrorNG_Websocket/commit/bc7a961e4db0b269e36cd15f1492410932ff7f5b))
* list server logs properly when disconnected ([f02d317](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f02d3174db39498749a6663984dcb4bea8ac342e))
* ListServer Ping not found in WebGL ([6c4b34b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/6c4b34ba065429b57ccfed71ac0adc325de19809))
* Lobby Remove button not showing for P1 when Server Only ([377c47c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/377c47ce74808dc7d2871eac80c4cd040894821b))
* maintain Unity's copyright notice ([#961](https://github.com/MirrorNG/MirrorNG_Websocket/issues/961)) ([7718955](https://github.com/MirrorNG/MirrorNG_Websocket/commit/771895509a358286377ea3d391ca45f8c0a3b48d))
* Make assembly definition 2018.4 compatible ([99ecc9e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/99ecc9ec770aa89d5087e5b95821ff3e2e444085))
* make build pass ([08df6d0](https://github.com/MirrorNG/MirrorNG_Websocket/commit/08df6d0694b10475301b21915214cbbfbbec2826))
* Make SendToReady non-ambiguous ([#1578](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1578)) ([b627779](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b627779acd68b2acfcaf5eefc0d3864dcce57fc7))
* making weaver include public fields in base classes in auto generated Read/Write ([#1977](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1977)) ([3db57e5](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3db57e5f61ac0748d3a6296d8ea44c202830796f))
* Mark weaver as failed if serializing invalid type ([03c767d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/03c767db6aea583bb00e56b1ac74bf29e8169a91))
* Message base class not being Serialized if processed in the wrong order ([#2023](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2023)) ([3418fa2](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3418fa210602cf1a9b9331b198ac47d8a3cabe69))
* MirrorNG works with 2019.2 ([9f35d6b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9f35d6be427843aa7dd140cde32dd843c62147ce))
* Misc Code Smells ([#257](https://github.com/MirrorNG/MirrorNG_Websocket/issues/257)) ([278a127](https://github.com/MirrorNG/MirrorNG_Websocket/commit/278a1279dabefe04b0829015841de68b41e60a7b))
* Misc code smells ([#269](https://github.com/MirrorNG/MirrorNG_Websocket/issues/269)) ([23dcca6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/23dcca61ff7c41e8b9f61579605fd56ee82c70e0))
* missed ushort reader/writer ([74faf2a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/74faf2a95b5a3e551e7ae344d5772e10ee198318))
* missing meta ([87ace4d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/87ace4dda09331968cc9d0185ce1de655f5dfb15))
* Mono.CecilX namespace to work around Unity 2019 Cecil namespace collision ([#832](https://github.com/MirrorNG/MirrorNG_Websocket/issues/832)) ([5262592](https://github.com/MirrorNG/MirrorNG_Websocket/commit/52625923b2d408018f61506ef93b15487764d095))
* move listserver classes into package ([2668b17](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2668b17162e5a9fbdce2cfc776f80044f9f4d0d9))
* move NetworkStreamExtension in a namespace ([12de543](https://github.com/MirrorNG/MirrorNG_Websocket/commit/12de543aa4da49edf3c14c69388f739ad315c84d))
* movement in room demo ([49f7904](https://github.com/MirrorNG/MirrorNG_Websocket/commit/49f7904b4a83fc5318031d273cb10a4b87af2172))
* MultiplexTransport GetMaxMessageSize NullReferenceException when called on server. And fixes potential exploits / out of sync issues where clients with different transports might see different game states because of different max message sizes. ([#1332](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1332)) ([b3127be](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b3127beb89c20447bf8044fd3bae71ae04f553e7))
* Network rigidbody fixes ([#2050](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2050)) ([0c30d33](https://github.com/MirrorNG/MirrorNG_Websocket/commit/0c30d3398aaabcbf094a88a9c9c77ab4d5062acf))
* NetworkBehaviour.SyncVarGameObjectEqual made protected again so that Weaver finds it again ([165a1dd](https://github.com/MirrorNG/MirrorNG_Websocket/commit/165a1dd94cd1a7bebc3365c4f40f968f500043a5))
* NetworkBehaviour.SyncVarNetworkIdentityEqual made protected again so that Weaver finds it again ([20a2d09](https://github.com/MirrorNG/MirrorNG_Websocket/commit/20a2d09d07ab2c47a204e5d583b538a92f72231e))
* NetworkBehaviourInspector wouldn't show SyncMode if syncvars / syncobjects were only private ([ed572da](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ed572da6a07791a243715796304c0f7695792225))
* NetworkClient.Shutdown calls ClientScene.Shutdown again to properly clean up client scene. ClientScene only cleans up itself without touching transport or NetworkIdentities (fixes the bug where the player object wouldn't be destroyed after calling StopClient) ([fb716df](https://github.com/MirrorNG/MirrorNG_Websocket/commit/fb716df12997417ce41a063508937d68a75991bf))
* NetworkConnectionEvent should be serialized in editor ([0e756ce](https://github.com/MirrorNG/MirrorNG_Websocket/commit/0e756cec06c5fda9eb4b5c8aa9de093c32b0315c))
* NetworkIdentity.OnStartLocalPlayer catches exceptions now too. fixes a potential bug where an exception in PlayerInventory.OnStartLocalPlayer would cause PlayerEquipment.OnStartLocalPlayer to not be called ([5ed5f84](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5ed5f844090442e16e78f466f7a785881283fbd4))
* NetworkIdentity.RebuildObservers: added missing null check for observers coming from components that implement OnRebuildObservers. Previously this caused a NullReferenceException. ([a5f495a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a5f495a77485b972cf39f8a42bae6d7d852be38c))
* NetworkIdentity.SetClientOwner: overwriting the owner was still possible even though it shouldn't be. all caller functions double check and return early if it already has an owner, so we should do the same here. ([548db52](https://github.com/MirrorNG/MirrorNG_Websocket/commit/548db52fdf224f06ba9d8b2d75460d31181b7066))
* NetworkManager OnValidate wouldn't properly save the automatically added Transport before because Undo.RecordObject is needed for that now. ([524abfc](https://github.com/MirrorNG/MirrorNG_Websocket/commit/524abfc5e8c881d2088a7f9f8bbf07c0371785cf))
* NetworkRoomManager.minPlayers is now protected so it's available for derived classes. ([3179f08](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3179f08e3dc11340227a57da0104b1c8d1d7b45d))
* NetworkServer.SpawnObjects: return false if server isn't running ([d4d524d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d4d524dad2a0a9d89538e6212dceda6bea71d2b7))
* NetworkTransform clientAuthority works again via clientAuthority option that is configurable in inspector. this had to be fixed after we removed local authority. ([d712cd0](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d712cd03039aea92083b1be97197f6272b2296b5))
* NinjaWS code smells ([#272](https://github.com/MirrorNG/MirrorNG_Websocket/issues/272)) ([71d9428](https://github.com/MirrorNG/MirrorNG_Websocket/commit/71d942804c0d404f287dc51b7bcdd1fcc39bcee8))
* no longer requires hook to be the first overload in a class ([#1913](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1913)) ([0348699](https://github.com/MirrorNG/MirrorNG_Websocket/commit/03486997fb0abb91d14f233658d375f21afbc3e3))
* non ready connections should not observe objects ([1352334](https://github.com/MirrorNG/MirrorNG_Websocket/commit/135233474752373b473b6094fe52bcb3ab3c4eae))
* not removing server if id is empty ([#2078](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2078)) ([f717945](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f7179455256bb7341ffa9e6921fe0de50498150a))
* NRE on gamemanager in scene ([#268](https://github.com/MirrorNG/MirrorNG_Websocket/issues/268)) ([58a124a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/58a124a99c267091142f00adc7f8898160a9dd97))
* NRE when destroying all objects ([#85](https://github.com/MirrorNG/MirrorNG_Websocket/issues/85)) ([71e78a7](https://github.com/MirrorNG/MirrorNG_Websocket/commit/71e78a7f5e15f99af89cd15c1ddd8a975e463916))
* null reference exception ([7ce95c5](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7ce95c5cea58446549d9a282b48c2e8b3f7c8323))
* OnClientEnterRoom should only fire on clients ([d9b7bb7](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d9b7bb735729e68ae399e1175d6c485a873b379e))
* OnClientReady is called and passed the appropriate ready state value in NetworkLobbyPlayer ([#618](https://github.com/MirrorNG/MirrorNG_Websocket/issues/618)) ([c9eac57](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c9eac57ce858d5977a03979e7514f9833a958d3c))
* OnSetHostVisibility can now check if it has authority ([888e46c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/888e46c6850c9d32c6428f72d0dddf5f7e8a8564))
* Optional Server or Client for PlayerSpawner ([#231](https://github.com/MirrorNG/MirrorNG_Websocket/issues/231)) ([3fa5f89](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3fa5f89d8c934b233330efe52b42e59198a920cb))
* overriden hooks are invoked (fixes [#1581](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1581)) ([#1584](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1584)) ([cf55333](https://github.com/MirrorNG/MirrorNG_Websocket/commit/cf55333a072c0ffe36a2972ca0a5122a48d708d0))
* pack works if message is boxed ([55c9bb6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/55c9bb625aa06ab83c2350b483eaca09b463db0a))
* pass the correct connection to TargetRpcs ([#146](https://github.com/MirrorNG/MirrorNG_Websocket/issues/146)) ([9df2f79](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9df2f798953f78de113ef6fa9fea111b03a52cd0))
* Pass the name of the invoking class and desired command when an object has no authority. ([#1216](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1216)) ([701f4f4](https://github.com/MirrorNG/MirrorNG_Websocket/commit/701f4f41838a01d9268335d16380f871abaf8cf5))
* port network discovery ([d6a1154](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d6a1154e98c52e7873411ce9d7b87f7b294dc436))
* Potential DOS attack by sending invalid UTF8 byte sequences  ([#727](https://github.com/MirrorNG/MirrorNG_Websocket/issues/727)) ([3cee3ab](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3cee3abc48fa58ab2bdb6affc8cbd4ae8b4fa815))
* Potential DOS attack on server by sending packed ulongs when packed uints are expected. ([#730](https://github.com/MirrorNG/MirrorNG_Websocket/issues/730)) ([015d0d5](https://github.com/MirrorNG/MirrorNG_Websocket/commit/015d0d508e193a694b254c182dcb0a906fe1f3bc))
* potential exploits / out of sync issues where clients with different transports might see different game states because of different max message sizes when using FallbackTransport. ([#1331](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1331)) ([5449840](https://github.com/MirrorNG/MirrorNG_Websocket/commit/54498403a540db62b3ac1994494ff071327330c9))
* potential null reference exception with debug logging ([33493a0](https://github.com/MirrorNG/MirrorNG_Websocket/commit/33493a0137a899754c433c428b13e6f6c621300b))
* Prevent Compiler Paradox ([#1145](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1145)) ([fd43c67](https://github.com/MirrorNG/MirrorNG_Websocket/commit/fd43c67d6866ede681024d3753b17ab5427e16f4))
* Prevent Double Call of NetworkServer.Destroy ([#1554](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1554)) ([2d1b142](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2d1b142276193be1e93a3a3f6ce482c87a134a2c))
* Prevent host client redundantly changing to offline scene ([b4511a0](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b4511a0637958f10f4a482364c654d1d9add5ef2))
* prevent NRE when operating as a separated client and server ([#283](https://github.com/MirrorNG/MirrorNG_Websocket/issues/283)) ([e10e198](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e10e198b4865fc8c941244c3e368eebc6cf73179))
* properly detect NT rotation ([#1516](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1516)) ([f0a993c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f0a993c1064384e0b3bd690d4d66be38875ed50e))
* properly stop client and server in OnApplicationQuit so that clients still get a chance to send then 'quit' packet instead of just timing out. Also fixes a bug where OnStopServer/OnStopClient were not called when stopping the Editor. ([#936](https://github.com/MirrorNG/MirrorNG_Websocket/issues/936)) ([d6389e6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d6389e68be3a951f3ddb9aa51c57a0e3c788e5f6))
* race condition closing tcp connections ([717f1f5](https://github.com/MirrorNG/MirrorNG_Websocket/commit/717f1f5ad783e13a6d55920e454cb91f380cd621))
* Re-enable transport if aborting additive load/unload ([#1683](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1683)) ([bc37497](https://github.com/MirrorNG/MirrorNG_Websocket/commit/bc37497ac963bb0f2820b103591afd05177d078d))
* Rebuild observers when we switch scenes, fixes [#978](https://github.com/MirrorNG/MirrorNG_Websocket/issues/978) ([#1016](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1016)) ([6dd1350](https://github.com/MirrorNG/MirrorNG_Websocket/commit/6dd135088bd0b3858dabf5d195d14d85879ead6d))
* release job requires node 10 ([3f50e63](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3f50e63bc32f4942e1c130c681dabd34ae81b117))
* release unitypackage ([#1355](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1355)) ([d0cc669](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d0cc6690178df0af02be7bfd1fa9aacd037c57be))
* remove customHandling as its no longer used ([#265](https://github.com/MirrorNG/MirrorNG_Websocket/issues/265)) ([dbd9d84](https://github.com/MirrorNG/MirrorNG_Websocket/commit/dbd9d84ee46ac90a8d78daba0c23fc9be71ca77d))
* Remove leftover AddPlayer methods now that extraData is gone ([#1751](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1751)) ([2d006fe](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2d006fe7301eb8a0194af9ce9244988a6877f8f0))
* remove pause network comment and log ([#238](https://github.com/MirrorNG/MirrorNG_Websocket/issues/238)) ([1a8c09d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/1a8c09d8a5a8cf70508d4e42e4912e3989478ff1))
* Remove RoomPlayer from roomSlots on Disconnect ([2a2f76c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2a2f76c263093c342f307856e400aeabbedc58df))
* remove samples from upm package ([#25](https://github.com/MirrorNG/MirrorNG_Websocket/issues/25)) ([a71e21f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a71e21fe6953f6edf54fed3499801e271e2447f3))
* remove scriptableobject error Tests ([479b78b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/479b78bf3cabe93938bf61b7f8fd63ba46da0f4a))
* remove tests from npm package ([#32](https://github.com/MirrorNG/MirrorNG_Websocket/issues/32)) ([5ed9b4f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5ed9b4f1235d5d1dc54c3f50bb1aeefd5dbe3038))
* remove Tests from UPM ([#33](https://github.com/MirrorNG/MirrorNG_Websocket/issues/33)) ([8f42af0](https://github.com/MirrorNG/MirrorNG_Websocket/commit/8f42af0a3992cfa549eb404ad9f9693101895ce9))
* remove Tests from upm package ([#34](https://github.com/MirrorNG/MirrorNG_Websocket/issues/34)) ([8d8ea0f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/8d8ea0f10743044e4a9a3d6c5b9f9973cf48e28b))
* Removed NetworkClient.Update because NetworkManager does it in LateUpdate ([984945e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/984945e482529bfc03bf735562f3eff297a1bad4))
* Removed NetworkServer.Listen because HostSetup does that ([cf6823a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/cf6823acb5151d5bc9beca2b0911a99dfbcd4472))
* Removed unnecessary registration of player prefab in NetworkRoomManager ([b2f52d7](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b2f52d78921ff0136c74bbed0980e3aaf5e2b379))
* Removed unused variable ([ae3dc04](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ae3dc04fb999c3b7133589ab631c1d23f1a8bdde))
* replace player (remove authority by default) ([#1261](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1261)) ([ad724fe](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ad724fe23c4776855ee1a2a22b53ae59ddac8992)), closes [#1257](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1257) [#1257](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1257) [#1257](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1257)
* Replaced Icosphere with centered pivot ([1dc0d98](https://github.com/MirrorNG/MirrorNG_Websocket/commit/1dc0d9837458c0403916476805f58442ff87e364))
* ReplacePlayer now calls OnStartLocalPlayer ([#1280](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1280)) ([0e1bc81](https://github.com/MirrorNG/MirrorNG_Websocket/commit/0e1bc8110fb3cc4e162464a2e080eac6c70ab95e)), closes [#962](https://github.com/MirrorNG/MirrorNG_Websocket/issues/962)
* Replacing ClearDelegates with RemoveDelegates for test ([#1971](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1971)) ([927c4de](https://github.com/MirrorNG/MirrorNG_Websocket/commit/927c4dede5930b320537150466e05112ebe70c3e))
* Report correct channel to profiler in SendToObservers ([0b84d4c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/0b84d4c5e1b8455e32eeb4d4c00b60bbc1301436))
* reset buffer every time ([a8a62a6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a8a62a64b6fa67223505505c1225269d3a047a92))
* Respect Player Prefab Position & Rotation ([#825](https://github.com/MirrorNG/MirrorNG_Websocket/issues/825)) ([8ebda0f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/8ebda0fa21b430ce1394eba8e7eeafa56d9290f3))
* return & continue on separate line ([#1504](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1504)) ([61fdd89](https://github.com/MirrorNG/MirrorNG_Websocket/commit/61fdd892d9e6882e1e51094a2ceddfadc8fd1ebc))
* Revert "NetworkClient.Shutdown: call ClientScene.Shutdown, otherwise it's never called" - caused client's player to not be removed from scene after disconnecting ([13bb748](https://github.com/MirrorNG/MirrorNG_Websocket/commit/13bb7486034b72e899365f1b0aed3707a3ac0cb1))
* Revert "NetworkIdentity.observers dictionary is always created, but always empty on clients. Gets rid of all null checks." to fix server-only bug not allowing movement on client, e.g. in uMMORPG ([f56507f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f56507f2fc9f36ca9f8e1df9a7a437a97b416d54))
* Revert "refactor:  consolidate prefab and spawn handlers ([#817](https://github.com/MirrorNG/MirrorNG_Websocket/issues/817))" to fix a bug where if editor=host, build=client, we receive scene object not found when walking out of and back into an observer's range ([1f07af0](https://github.com/MirrorNG/MirrorNG_Websocket/commit/1f07af0cae7b41cd52df621f1b5cfcefc77efdfa))
* Room example to use new override ([e1d1d41](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e1d1d41ed69f192b5fb91f92dcdeae1ee057d38f))
* rooms demo ([44598e5](https://github.com/MirrorNG/MirrorNG_Websocket/commit/44598e58325c877bd6b53ee5a77dd95e421ec404))
* Round Robin Spawning by Hierarchy Order ([#790](https://github.com/MirrorNG/MirrorNG_Websocket/issues/790)) ([531e202](https://github.com/MirrorNG/MirrorNG_Websocket/commit/531e202bbec43d855b0ba24e445588fda2f08102)), closes [#724](https://github.com/MirrorNG/MirrorNG_Websocket/issues/724)
* SceneId was not set to 0 for prefab variants ([#976](https://github.com/MirrorNG/MirrorNG_Websocket/issues/976)) ([#977](https://github.com/MirrorNG/MirrorNG_Websocket/issues/977)) ([2ca2c48](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2ca2c488acc3966ef7dc67cb530c5db9eaa8b0ea))
* SceneManager Exceptions and Tests ([#287](https://github.com/MirrorNG/MirrorNG_Websocket/issues/287)) ([388d218](https://github.com/MirrorNG/MirrorNG_Websocket/commit/388d21872bb8b4c7f9d3742ecfa9b857ee734dfa))
* SendToAll sends to that exact connection if it is detected as local connection, instead of falling back to the .localConnection field which might be something completely different. ([4b90aaf](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4b90aafe12970e00949ee43b07b9edd5213745da))
* SendToObservers missing result variable ([9c09c26](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9c09c26a5cd28cadae4049fea71cddc38c00cf79))
* SendToObservers sends to that exact connection if it is detected as local connection, instead of falling back to the .localConnection field which might be something completely different. ([4267983](https://github.com/MirrorNG/MirrorNG_Websocket/commit/426798313920d23548048aa1c678167fd9b45cbd))
* SendToReady sends to that exact connection if it is detected as local connection, instead of falling back to the .localConnection field which might be something completely different. ([4596b19](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4596b19dd959722d5dc659552206fe90c015fb01))
* set authority when replacing the player ([2195fee](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2195fee81c455ac6c2ea7cca28290fbda6f30260))
* Set syncvar variables after calling the hook ([#659](https://github.com/MirrorNG/MirrorNG_Websocket/issues/659)) ([2d63ee1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2d63ee13180a54d06ce68b641f35ee2a7702cffa))
* set version number ([#1338](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1338)) ([0d1d7b5](https://github.com/MirrorNG/MirrorNG_Websocket/commit/0d1d7b5a1c0e6d94c5749a94aa7b75f2c9a2ca0d))
* show private serializable fields in network behavior inspector ([#1557](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1557)) ([b8c87d9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b8c87d9053e7fd7c3b69bcf1d4179e6e4c9bc4a6))
* smell cleanup left if bug. repaired with parenthesis. ([#275](https://github.com/MirrorNG/MirrorNG_Websocket/issues/275)) ([dd52be3](https://github.com/MirrorNG/MirrorNG_Websocket/commit/dd52be3bb9406de7b2527c72fce90c9ed6c9d5bf))
* Spawn Handler Order ([#223](https://github.com/MirrorNG/MirrorNG_Websocket/issues/223)) ([8674274](https://github.com/MirrorNG/MirrorNG_Websocket/commit/86742740ef2707f420d5cb6aeeb257bf07511f0b)), closes [#222](https://github.com/MirrorNG/MirrorNG_Websocket/issues/222)
* spawnwithauthority works again in host mode ([5b04836](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5b04836bb220b8fc0a8c3d0a3636966af3c538f2))
* stack overflow getting logger ([55e075c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/55e075c872a076f524ec62f44d81df17819e81ba))
* Stop calling ClientDisconnect on host ([#597](https://github.com/MirrorNG/MirrorNG_Websocket/issues/597)) ([b67b3e4](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b67b3e43049405808fe123276b3637c625b0ca9b))
* StopHost with offline scene calls scene change twice ([#1409](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1409)) ([a0c96f8](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a0c96f85189bfc9b5a936a8a33ebda34b460f17f))
* Suppress warning ([fffd462](https://github.com/MirrorNG/MirrorNG_Websocket/commit/fffd462df8cc1c0265890cdfa4ceb3e24606b1c1))
* suppress warning on standalone build [#1053](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1053) ([4ef680a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4ef680a47483890d6576784ca880f2b3536b6b7f))
* Suspend server transport while changing scenes ([#1169](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1169)) ([e8fac8a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e8fac8aba5c570edfb3346c1f68ad9e5fd3b1176))
* sync events can not have the same name if they are in different classes ([#2054](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2054)) ([c91308f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c91308fb0461e54292940ce6fa42bb6cd9800d89))
* Sync full netAnimator for new clients, fix [#980](https://github.com/MirrorNG/MirrorNG_Websocket/issues/980) ([#1110](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1110)) ([db8310f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/db8310f8385ec45c28356e59d1ba4ef8f4c9ab47))
* syncvars in commands work again ([#1131](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1131)) ([c24a73f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c24a73f6c9bbe25e98a6708f05b89a63dfc54b74))
* syntax error in release job ([2eeaea4](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2eeaea41bc81cfe0c191b39da912adc565e11ec7))
* TargetRpc now works accross assemblies ([#1130](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1130)) ([5ecd646](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5ecd646134791c80d8b53759de0d8aafddc31aeb)), closes [#1128](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1128)
* tcp server Tests ([3b95477](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3b954777f16a41469d953e3744c5d68554e3d200))
* Telepathy already supports IPv6, but can no also connect to IPv4-only servers again (e.g. Mirror Booster) ([488446a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/488446ae040246a631f8921a4cd5bdbb6a6e54d1))
* Telepathy fix a bug where calling Disconnect while connecting to a dead end would freeze Unity because .Join would wait forever. Interrupt fixes it. ([3831cbd](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3831cbddbea7d98fe8a871133a0ba2bf14f22df0))
* Telepathy forgot to set socket options for accepted clients on the server ([22931fc](https://github.com/MirrorNG/MirrorNG_Websocket/commit/22931fcd84e402a60b74f5261313c830913754fc))
* Telepathy reverted to older version to fix freezes when calling Client.Disconnect on some platforms like Windows 10 ([d0d77b6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d0d77b661cd07e25887f0e2f4c2d72b4f65240a2))
* Telepathy updated to latest version (IPv6 fix again) ([535b4d4](https://github.com/MirrorNG/MirrorNG_Websocket/commit/535b4d40fa50cec9abfac37c61aaf207ecbb43b9))
* Telepathy updated to latest version (Send SocketExceptions now disconnect the player too) ([98d3fb0](https://github.com/MirrorNG/MirrorNG_Websocket/commit/98d3fb0c31b7ac8bd27ec176ebdf7fb19908d472))
* Telepathy updated to latest version: Correctly support IPv4 and IPv6 sockets ([2761ff2](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2761ff23f459b5647a5700c9b9b29abdcff13f97))
* Telepathy updated to latest version: protect against allocation attacks via MaxMessageSize. Can be configured in the TelepathyTransport component now. ([67d715f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/67d715fe7416e790bcddcd4e23bb2cb8fbbc54e8))
* Telepathy updated to latest version. connectionId counter is properly reset after stopping server. ([abf06df](https://github.com/MirrorNG/MirrorNG_Websocket/commit/abf06df25d932d3cfb016e2da0bb5e4ee72d259d))
* Telepathy updated to latest version. Threads are closed properly now. ([4007423](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4007423db28f7044f6aa97b108a6bfbe3f2d46a9))
* Telepathy works on .net core again ([cb3d9f0](https://github.com/MirrorNG/MirrorNG_Websocket/commit/cb3d9f0d08a961b345ce533d1ce64602f7041e1c))
* TelepathyTransport.ToString UWP exception ([8a190bf](https://github.com/MirrorNG/MirrorNG_Websocket/commit/8a190bfd176f043322097e64bd041e80e38cc6d2))
* the Room scene references other scenes ([9b60871](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9b60871e2ea1a2912c0af3d95796660fc04dc569))
* there is no lobby example ([b1e05ef](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b1e05efb19984ce615d20a16a6c4b09a8897da6a))
* update NetworkIdentityEditor FindProperty to renamed variables ([a2cc14b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a2cc14bd202311aa36e61804183c983c6df8c7b4))
* Updated NetworkRoomPlayer inspector and doc and image ([a4ffcbe](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a4ffcbe280e2e2318d7cd2988379af74f0d32021))
* Updated Telepathy to latest version to fix IPAddress.Parse error for "localhost" ([cc6e4f6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/cc6e4f696dbc462c3880a2c9fc73163d88351b5a))
* Use big endian for packet size ([1ddcbec](https://github.com/MirrorNG/MirrorNG_Websocket/commit/1ddcbec93509e14169bddbb2a38a7cf0d53776e4))
* Use path instead of name in Room Example ([5d4bc47](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5d4bc47d46098f920f9e3468d0f276e336488e42))
* Use ReplaceHandler instead of RegisterHandler in NetworkManager ([ffc276c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ffc276cb79c4202964275642097451b78a817c8a))
* version file ([#1337](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1337)) ([ed7e509](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ed7e509ed6f77f2e694966a1c21130e3488f443d))
* weaver Cmd/Rpc/Target prefix check is no longer trash ([#707](https://github.com/MirrorNG/MirrorNG_Websocket/issues/707)) ([699a261](https://github.com/MirrorNG/MirrorNG_Websocket/commit/699a261e91078b65f3fb1a51a5838b05be2c87d6))
* weaver now processes multiple SyncEvent per class ([#2055](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2055)) ([b316b35](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b316b35d46868a7e11c7b2005570efeec843efe1))
* weaver support array of custom types ([#1470](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1470)) ([d0b0bc9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d0b0bc92bc33ff34491102a2f9e1855f2a5ed476))
* weaver syncLists now checks for SerializeItem in base class ([#1768](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1768)) ([1af5b4e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/1af5b4ed2f81b4450881fb11fa9b4b7e198274cb))
* webgl build fix [#1136](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1136) ([#1137](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1137)) ([c85d0df](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c85d0df5332c63c0e0107e6c99cea5de37c087fc))
* Websockets Transport now handles being disabled for scene changes ([#1994](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1994)) ([5480a58](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5480a583e13b9183a3670450af639f4e766cc358))
* WebSockets: Force KeepAliveInterval to Zero ([9a42fe3](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9a42fe334251852ab12e721db72cb12e98de82e8))
* when modifying a prefab, Unity calls OnValidate for all scene objects based on that prefab, which caused Mirror to reset the sceneId because we only checked if a prefab is currently edited, not if THIS prefab is currently edited ([db99dd7](https://github.com/MirrorNG/MirrorNG_Websocket/commit/db99dd7b3d4c93969c02c5fa7b3e3a1a2948cd7e))
* workaround for [#791](https://github.com/MirrorNG/MirrorNG_Websocket/issues/791) ([5c850aa](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5c850aa9ca5b480449c453aa14191aeb9998e6cb))
* Wrong method names in ClientSceneTests ([ab3f353](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ab3f353b33b3068a6ac1649613a28b0977a72685))
* **serialization:** Added NetworkWriter tests, found and fixed a bug in Write(Ray). ([#769](https://github.com/MirrorNG/MirrorNG_Websocket/issues/769)) ([99c8f5c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/99c8f5c356d2e3bd298fbd3508a3ed2abcb04351))
* **tests:** Added missing SyncListByteValid test file ([#634](https://github.com/MirrorNG/MirrorNG_Websocket/issues/634)) ([b0af876](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b0af87622159ceca9aebf4d939a3b7ad733fbe4f))
* **weaver:** [#696](https://github.com/MirrorNG/MirrorNG_Websocket/issues/696) detect .mystruct = new MyStruct() changes with syncvars ([#702](https://github.com/MirrorNG/MirrorNG_Websocket/issues/702)) ([053949b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/053949b7d2e1e3178025a75cddb6e47b83cdbd48))
* **weaver:** fix [#706](https://github.com/MirrorNG/MirrorNG_Websocket/issues/706) find system dlls ([#729](https://github.com/MirrorNG/MirrorNG_Websocket/issues/729)) ([53be9b6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/53be9b6d9949645d5334690961ff31f90065a93a))
* **weaver:** fix [#796](https://github.com/MirrorNG/MirrorNG_Websocket/issues/796), reload assemblies after initial import ([#1106](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1106)) ([d91b387](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d91b387bb29bdba06a62a718533db5c0fe52f642))
* **websocket:** [#829](https://github.com/MirrorNG/MirrorNG_Websocket/issues/829) fix InvalidOperationException with wss:// ([#830](https://github.com/MirrorNG/MirrorNG_Websocket/issues/830)) ([2d682b5](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2d682b5fad2811d3838e8d61ccaea381cc218bb2))
* **websocket:** Remove send queues (they never worked) and SSL (temporarily) ([#879](https://github.com/MirrorNG/MirrorNG_Websocket/issues/879)) ([3c60b08](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3c60b087627175833c616619941722927aa9cd5d))
* **websocket:** Use a buffer for most WS messages in WebGL client resulting in 0 alloc for most messages ([#848](https://github.com/MirrorNG/MirrorNG_Websocket/issues/848)) ([8967a20](https://github.com/MirrorNG/MirrorNG_Websocket/commit/8967a20244a2e16e3861d60c1d13c9e808248607))


### Code Refactoring

*  Client and server keep their own spawned list ([#71](https://github.com/MirrorNG/MirrorNG_Websocket/issues/71)) ([c2599e2](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c2599e2c6157dd7539b560cd4645c10713a39276))
* observers is now a set of connections ([#74](https://github.com/MirrorNG/MirrorNG_Websocket/issues/74)) ([4848920](https://github.com/MirrorNG/MirrorNG_Websocket/commit/484892058b448012538754c4a1f2eac30a42ceaa))
* Remove networkAddress from NetworkManager ([#67](https://github.com/MirrorNG/MirrorNG_Websocket/issues/67)) ([e89c32d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e89c32dc16b3d9b9cdcb38f0d7d170da94dbf874))
* Remove offline/online scenes ([#120](https://github.com/MirrorNG/MirrorNG_Websocket/issues/120)) ([a4c881a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a4c881a36e26b20fc72166741e20c84ce030ad8f))


### Features

* [#869](https://github.com/MirrorNG/MirrorNG_Websocket/issues/869) support structs in other assemblies ([#1022](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1022)) ([62d1887](https://github.com/MirrorNG/MirrorNG_Websocket/commit/62d1887e62c7262e9e88c0c72190b82324d644e4))
* Add excludeOwner option to ClientRpc ([#1954](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1954)) ([864fdd5](https://github.com/MirrorNG/MirrorNG_Websocket/commit/864fdd5fdce7a35ee4bf553176ed7a4ec3dc0653)), closes [#1963](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1963) [#1962](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1962) [#1961](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1961) [#1960](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1960) [#1959](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1959) [#1958](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1958) [#1957](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1957) [#1956](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1956)
* Add fallback transport ([1b02796](https://github.com/MirrorNG/MirrorNG_Websocket/commit/1b02796c1468c1e1650eab0f278cd9a11cc597c7))
* Add Network Menu  ([#253](https://github.com/MirrorNG/MirrorNG_Websocket/issues/253)) ([d81f444](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d81f444c42475439d24bf5b4abd2bbf15fd34e92))
* Add NetworkServer.RemovePlayerForConnection ([#1772](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1772)) ([e3790c5](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e3790c51eb9b79bebc48522fb832ae39f11d31e2))
* Add roomPlayer parameter to OnRoomServerCreateGamePlayer ([#1317](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1317)) ([abf5cdc](https://github.com/MirrorNG/MirrorNG_Websocket/commit/abf5cdcf36574a00995f5c229ebcbc41d0286546))
* Add Sensitivity to NetworkTransform ([#1425](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1425)) ([f69f174](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f69f1743c54aa7810c5a218e2059c115760c54a3))
* Add SyncHashSet and SyncSortedSet ([#685](https://github.com/MirrorNG/MirrorNG_Websocket/issues/685)) ([695979e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/695979e914882dd9ea80058474f147cd031d408f))
* add SyncList.RemoveAll ([#1881](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1881)) ([eb7c87d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/eb7c87d15aa2fe0a5b0c08fc9cde0adbeba0b416))
* Add UPM configuration ([#11](https://github.com/MirrorNG/MirrorNG_Websocket/issues/11)) ([9280af1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9280af158317597a53f6ddf5da4191b607e0c0f1))
* Add version to package file ([#1361](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1361)) ([e97ab93](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e97ab9379f798063e50a433ea6c2759f73d199ac))
* Add weaver support for Vector2Int and Vector3Int ([#646](https://github.com/MirrorNG/MirrorNG_Websocket/issues/646)) ([e2a6ce9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e2a6ce98114adda39bd28ec1fe31f337fc6bafc4))
* Added NetworkConnection to OnRoomServerSceneLoadedForPlayer ([b5dfcf4](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b5dfcf45bc9838e89dc37b00cf3653688083bdd8))
* Added Read<T> Method to NetworkReader ([#1480](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1480)) ([58df3fd](https://github.com/MirrorNG/MirrorNG_Websocket/commit/58df3fd6d6f53336668536081bc33e2ca22fd38d))
* Added SyncList.Find and SyncList.FindAll ([#1716](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1716)) ([0fe6328](https://github.com/MirrorNG/MirrorNG_Websocket/commit/0fe6328800daeef8680a19a394260295b7241442)), closes [#1710](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1710)
* Added Virtual OnRoomStopServer to NetworkRoomManager and Script Template ([d034ef6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d034ef616f3d479729064d652f74a905ea05b495))
* Added virtual SyncVar hook for index in NetworkRoomPlayer ([0c3e079](https://github.com/MirrorNG/MirrorNG_Websocket/commit/0c3e079d04a034f4d4ca8a34c88188013f36c377))
* adding demo for mirror cloud services ([#2026](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2026)) ([f1fdc95](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f1fdc959dcd62e7228ecfd656bc87cbabca8c1bc))
* Adding ignoreAuthority Option to Command ([#1918](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1918)) ([3ace2c6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3ace2c6eb68ad94d78c57df6f63107cca466effa))
* adding log handler that sets console color ([#2001](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2001)) ([4623978](https://github.com/MirrorNG/MirrorNG_Websocket/commit/46239783f313159ac47e192499aa8e7fcc5df0ec))
* Adding onLocalPlayerChanged to ClientScene for when localPlayer is changed ([#1920](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1920)) ([b4acf7d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b4acf7d9a20c05eadba8d433ebfd476a30e914dd))
* adding OnRoomServerPlayersNotReady to NetworkRoomManager that is called when player ready changes and atleast 1 player is not ready ([#1921](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1921)) ([9ae7fa2](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9ae7fa2a8c683f5d2a7ebe6c243a2d95acad9683))
* Adding ReplaceHandler functions to NetworkServer and NetworkClient ([#1775](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1775)) ([877f4e9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/877f4e9c729e5242d4f8c9653868a3cb27c933db))
* adding script that displays ping ([#1975](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1975)) ([7e93030](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7e93030849c98f0bc8d95fa310d208fef3028b29))
* additive scene msging added to server ([#285](https://github.com/MirrorNG/MirrorNG_Websocket/issues/285)) ([bd7a17a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/bd7a17a65fbc9aed64aaef6c65641697e8d89a74))
* allow more than one NetworkManager ([#135](https://github.com/MirrorNG/MirrorNG_Websocket/issues/135)) ([92968e4](https://github.com/MirrorNG/MirrorNG_Websocket/commit/92968e4e45a33fa5ab77ce2bfc9e8f826a888711))
* Allow Multiple Network Animator ([#1778](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1778)) ([34a76a2](https://github.com/MirrorNG/MirrorNG_Websocket/commit/34a76a2834cbeebb4c623f6650c1d67345b386ac))
* allow Play mode options ([f9afb64](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f9afb6407b015c239975c5a1fba6609e12ab5c8f))
* allow users to detect mirror version 3 ([ee9c737](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ee9c737bdaf47ff48fb72c017731fb61e63043b1))
* Allowing extra base types to be used for SyncLists and other SyncObjects ([#1729](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1729)) ([9bf816a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9bf816a014fd393617422ee6efa52bdf730cc3c9))
* Allowing Multiple Concurrent Additive Scenes ([#1697](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1697)) ([e32a9b6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e32a9b6f0b0744b6bd0eeeb0d9fca0b4dc33cbdf))
* An authenticator that times out other authenticators ([#1211](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1211)) ([09f6892](https://github.com/MirrorNG/MirrorNG_Websocket/commit/09f6892c55f74d3d480621b7d334154a979d3b6a))
* async multiplex transport ([#145](https://github.com/MirrorNG/MirrorNG_Websocket/issues/145)) ([c0e7e92](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c0e7e9280931a5996f595e41aa516bef20208b6f))
* asynchronous transport ([#134](https://github.com/MirrorNG/MirrorNG_Websocket/issues/134)) ([0e84f45](https://github.com/MirrorNG/MirrorNG_Websocket/commit/0e84f451e822fe7c1ca1cd04e052546ed273cfce))
* Authentication Framework ([#1057](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1057)) ([56bcb02](https://github.com/MirrorNG/MirrorNG_Websocket/commit/56bcb02c158050001e1910852df5994c1995424c))
* Authenticators can now provide AuthenticationData ([310ce81](https://github.com/MirrorNG/MirrorNG_Websocket/commit/310ce81c8378707e044108b94faac958e35cbca6))
* awaitable connect ([#55](https://github.com/MirrorNG/MirrorNG_Websocket/issues/55)) ([952e8a4](https://github.com/MirrorNG/MirrorNG_Websocket/commit/952e8a43e2b2e4443e24865c60af1ee47467e4cf))
* Block Play Mode and Builds for Weaver Errors ([#1479](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1479)) ([0e80e19](https://github.com/MirrorNG/MirrorNG_Websocket/commit/0e80e1996fb2673364169782c330e69cd598a21d))
* Button to register all prefabs in NetworkClient ([#179](https://github.com/MirrorNG/MirrorNG_Websocket/issues/179)) ([9f5f0b2](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9f5f0b27f8857bf55bf4f5ffbd436247f99cf390))
* Chat example ([#1305](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1305)) ([9926472](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9926472d98730d8fc77231c5ea261158bd09d46b))
* Check for client authority in CmdClientToServerSync ([#1500](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1500)) ([8b359ff](https://github.com/MirrorNG/MirrorNG_Websocket/commit/8b359ff6d07352a751f200768dcde6febd8e9303))
* Check for client authority in NetworkAnimator Cmd's ([#1501](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1501)) ([ecc0659](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ecc0659b87f3d910dc2370f4861ec70244a25622))
* Client attribute now throws error ([#274](https://github.com/MirrorNG/MirrorNG_Websocket/issues/274)) ([f1b52f3](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f1b52f3d23e9aa50b5fab8509f3c769e97eac2e7))
* ClientRpc no longer need Rpc prefix ([#2086](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2086)) ([eb93c34](https://github.com/MirrorNG/MirrorNG_Websocket/commit/eb93c34b330189c79727b0332bb66f3675cfd641))
* ClientScene uses log window ([b3656a9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b3656a9edc5ff00329ce00847671ade7b8f2add2))
* Commands no longer need Cmd prefix ([#2084](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2084)) ([b6d1d09](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b6d1d09f846f7cf0310db0db9d931a9cfbbb36b2))
* Commands no longer need to start with Cmd ([#263](https://github.com/MirrorNG/MirrorNG_Websocket/issues/263)) ([9578e19](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9578e19ff70bf3a09a9fe31926c8ac337f945ba9))
* Component based NetworkSceneManager ([#244](https://github.com/MirrorNG/MirrorNG_Websocket/issues/244)) ([7579d71](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7579d712ad97db98cd729c51568631e4c3257b58))
* component based SyncToOwner, fixes [#39](https://github.com/MirrorNG/MirrorNG_Websocket/issues/39) ([#1023](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1023)) ([c6d86b3](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c6d86b301ba19ad8bdaadff12e347f77c621cdc2))
* connections can retrieve end point ([#114](https://github.com/MirrorNG/MirrorNG_Websocket/issues/114)) ([d239718](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d239718498c5750edf0b5d11cc762136f45500fd))
* Cosmetic Enhancement of Network Manager ([#1512](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1512)) ([f53b12b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f53b12b2f7523574d7ceffa2a833dbd7fac755c9))
* Creating method to replace all log handlers ([#1880](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1880)) ([d8aaf76](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d8aaf76fb972dd153f6002edb96cd2b9350e572c))
* custom reader/writer via extension methods ([#1047](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1047)) ([b45afad](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b45afad641b1dd9cca3eb3046f6b727d7063d4ef))
* default log level option ([#1728](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1728)) ([5c56adc](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5c56adc1dc47ef91f7ee1d766cd70fa1681cb9df))
* Disconnect Dead Clients ([#1724](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1724)) ([a2eb666](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a2eb666f158d72851d6c62997ed4b24dc3c473bc)), closes [#1753](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1753)
* Disposable PooledNetworkReader / PooledNetworkWriter ([#1490](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1490)) ([bb55baa](https://github.com/MirrorNG/MirrorNG_Websocket/commit/bb55baa679ae780e127ed5817ef10d7f12cd08c8))
* Example with 10k monster that change unfrequently ([2b2e71c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2b2e71cc007dba2c1d90b565c4983814c1e0b7d1))
* Exclude fields from weaver's automatic Read/Write using System.NonSerialized attribute  ([#1727](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1727)) ([7f8733c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7f8733ce6a8f712c195ab7a5baea166a16b52d09))
* Experimental Network Transform ([#1990](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1990)) ([7e2b733](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7e2b7338a18855f156e52b663ac24eef153b43a7))
* Experimental NetworkRigidbody  ([#1822](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1822)) ([25285b1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/25285b1574c4e025373e86735ec3eb9734272fd2))
* fallback transport now supports uri ([#1296](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1296)) ([e4a701e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e4a701ed4e22f1ad89fc3805fa63fe9fef61a8e0))
* generate serializers for IMessageBase structs ([#1353](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1353)) ([3c0bc28](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3c0bc2822847410213ee137f6e848c7be296d65a))
* get a convenient property to get network time ([1e8c2fe](https://github.com/MirrorNG/MirrorNG_Websocket/commit/1e8c2fe0522d7843a6a2fae7287287c7afa4e417))
* HasAuthority attribute now throws error ([#276](https://github.com/MirrorNG/MirrorNG_Websocket/issues/276)) ([da2355b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/da2355b4c1a51dbcbf6ceb405b6fc7b5bb14fa14))
* Implement IReadOnlyList<T> in SyncLists ([#903](https://github.com/MirrorNG/MirrorNG_Websocket/issues/903)) ([3eaaa77](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3eaaa773b3c126897ed0c84c2e776045793556f7))
* Implemented NetworkReaderPool ([#1464](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1464)) ([9257112](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9257112c65c92324ad0bd51e4a017aa1b4c9c1fc))
* Improve weaver error messages ([#1779](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1779)) ([bcd76c5](https://github.com/MirrorNG/MirrorNG_Websocket/commit/bcd76c5bdc88af6d95a96e35d47b1b167d375652))
* Improved Log Settings Window Appearance ([#1885](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1885)) ([69b8451](https://github.com/MirrorNG/MirrorNG_Websocket/commit/69b845183c099744455e34c6f12e75acecb9098a))
* Improved RoomPayer template ([042b4e1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/042b4e1965580a4cdbd5ea50b11a1377fe3bf3cc))
* include generated changelog ([#27](https://github.com/MirrorNG/MirrorNG_Websocket/issues/27)) ([a60f1ac](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a60f1acd3a544639a5e58a8946e75fd6c9012327))
* Include version in release ([#1336](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1336)) ([e4f89cf](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e4f89cf12f6dca42bbb5c25e50f03ed7fcde3f82))
* individual events for SyncDictionary ([#112](https://github.com/MirrorNG/MirrorNG_Websocket/issues/112)) ([b3c1b16](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b3c1b16100c440131d6d933627a9f6479aed11ad))
* individual events for SyncSet ([#111](https://github.com/MirrorNG/MirrorNG_Websocket/issues/111)) ([261f5d6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/261f5d6a1481634dc524fb57b5866e378a1d909d))
* LAN Network discovery ([#1453](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1453)) ([e75b45f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e75b45f8889478456573ea395694b4efc560ace0)), closes [#38](https://github.com/MirrorNG/MirrorNG_Websocket/issues/38)
* LLAPI transport can receive port from uri ([#1294](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1294)) ([7865a84](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7865a840b66db74acfdf48989adec2c72222020c))
* LocalPlayer attribute now throws error ([#277](https://github.com/MirrorNG/MirrorNG_Websocket/issues/277)) ([15aa537](https://github.com/MirrorNG/MirrorNG_Websocket/commit/15aa537947cd14e4d71853f1786c387519d8828b))
* logger factory works for static classes by passing the type ([f9328c7](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f9328c771cfb0974ce4765dc0d5af01440d838c0))
* logging api ([#1611](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1611)) ([f2ccb59](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f2ccb59ae6db90bc84f8a36802bfe174b4493127))
* LogSettings that can be saved and included in a build ([#1863](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1863)) ([fd4357c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/fd4357cd264b257aa648a26f9392726b2921b870))
* Mirror Icon for all components ([#1452](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1452)) ([a7efb13](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a7efb13e29e0bc9ed695a86070e3eb57b7506b4c))
* Mirror now supports message inheritance ([#1286](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1286)) ([f9d34d5](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f9d34d586368df2917a0ee834f823a4dd140cb31))
* More examples for Mirror Cloud Service ([#2029](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2029)) ([7d0e907](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7d0e907b73530c9a625eaf663837b7eeb36fcee6))
* Multiple Concurrent Additive Physics Scenes Example ([#1686](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1686)) ([87c6ebc](https://github.com/MirrorNG/MirrorNG_Websocket/commit/87c6ebc5ddf71b3fc358bb1a90bd9ee2470e333c))
* Multiplex based on url ([#1295](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1295)) ([c206f9a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c206f9ad974249c5514fad6ef21b27387d1b7ace))
* Network Animator can reset triggers ([#1420](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1420)) ([dffdf02](https://github.com/MirrorNG/MirrorNG_Websocket/commit/dffdf02be596db3d35bdd8d19ba6ada7d796a137))
* Network Scene Checker Component ([#1271](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1271)) ([71c0d3b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/71c0d3b2ee1bbdb29d1c39ee6eca3ef9635d70bf))
* network writer and reader now support uri ([0c2556a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/0c2556ac64bd93b9e52dae34cf8d84db114b4107))
* network writer pool to avoid expensive allocations ([3659acb](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3659acbbdd43321e22269591bfd08189b40e6b44))
* network writer pool to avoid expensive allocations ([#928](https://github.com/MirrorNG/MirrorNG_Websocket/issues/928)) ([f5e9318](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f5e93180a1161e62ef74eb5c5ad81308e91d5687))
* NetworkAnimator warns if you use it incorrectly ([#1424](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1424)) ([c30e4a9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c30e4a9f83921416f936ef5fd1bb0e2b3a410807))
* NetworkClient raises event after authentication ([#96](https://github.com/MirrorNG/MirrorNG_Websocket/issues/96)) ([c332271](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c332271d918f782d4b1a84b3f0fd660239f95743))
* NetworkConnection is optional for handlers ([#1202](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1202)) ([bf9eb61](https://github.com/MirrorNG/MirrorNG_Websocket/commit/bf9eb610dced2434f4a045f5b01bc758b9f72327))
* NetworkConnection manages messages handlers ([#93](https://github.com/MirrorNG/MirrorNG_Websocket/issues/93)) ([5c79f0d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5c79f0db64e46905081e6c0b5502376c5acf0d99))
* NetworkConnection to client and server use logger framework ([72154f1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/72154f1daddaa141fb3b8fe02bcfdf098ef1d44a))
* NetworkConnection uses logging framework ([ec319a1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ec319a165dc8445b00b096d09061adda2c7b8b9d))
* NetworkIdentity lifecycle events ([#88](https://github.com/MirrorNG/MirrorNG_Websocket/issues/88)) ([9a7c572](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9a7c5726eb3d333b85c3d0e44b884c11e34be45d))
* NetworkIdentity use logger framework ([2e39e13](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2e39e13c012aa79d50a54fc5d07b85da3e52391b))
* NetworkMatchChecker Component ([#1688](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1688)) ([21acf66](https://github.com/MirrorNG/MirrorNG_Websocket/commit/21acf661905ebc35f31a52eb527a50c6eff68a44)), closes [#1685](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1685) [#1681](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1681) [#1689](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1689)
* NetworkSceneChecker use Scene instead of string name ([#1496](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1496)) ([7bb80e3](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7bb80e3b796f2c69d0958519cf1b4a9f4373268b))
* NetworkServer uses new logging framework ([8b4f105](https://github.com/MirrorNG/MirrorNG_Websocket/commit/8b4f1051f27f1d5b845e6bd0a090368082ab1603))
* NetworkServer.SendToReady ([#1773](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1773)) ([f6545d4](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f6545d4871bf6881b3150a3231af195e7f9eb8cd))
* new virtual OnStopServer called when object is unspawned ([#1743](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1743)) ([d1695dd](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d1695dd16f477fc9edaaedb90032c188bcbba6e2))
* new way to connect using uri ([#1279](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1279)) ([7c3622c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7c3622cfaed0c062f51342294264c8b389b2846d))
* new websocket transport ([#156](https://github.com/MirrorNG/MirrorNG_Websocket/issues/156)) ([23c7b0d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/23c7b0d1b32684d4f959495fe96b2d16a68bd356))
* next gen async transport ([#106](https://github.com/MirrorNG/MirrorNG_Websocket/issues/106)) ([4a8dc67](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4a8dc676b96840493d178718049b9e20c8eb6510))
* now you can assign scenes even if not in Editor ([#1576](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1576)) ([c8a1a5e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c8a1a5e56f7561487e3180f26e28484f714f36c1))
* Now you can pass NetworkIdentity and GameObjects ([#83](https://github.com/MirrorNG/MirrorNG_Websocket/issues/83)) ([dca2d40](https://github.com/MirrorNG/MirrorNG_Websocket/commit/dca2d4056fe613793480b378d25509284a1fd46a))
* onstopserver event in NetworkIdentity ([#186](https://github.com/MirrorNG/MirrorNG_Websocket/issues/186)) ([eb81190](https://github.com/MirrorNG/MirrorNG_Websocket/commit/eb8119007b19faca767969700b0209ade135650c))
* Pass all information to spawn handler ([#1215](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1215)) ([d741bae](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d741baed789366ed7ce93f289eac3552dfe54fdc))
* Piped connection ([#138](https://github.com/MirrorNG/MirrorNG_Websocket/issues/138)) ([471a881](https://github.com/MirrorNG/MirrorNG_Websocket/commit/471a881cdae1c6e526b5aa2d552cc91dc27f793a))
* PlayerSpawner component ([#123](https://github.com/MirrorNG/MirrorNG_Websocket/issues/123)) ([e8b933d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e8b933ddff9a47b64be371edb63af130bd3958b4))
* Prettify Log Names ([c7d8c09](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c7d8c0933d37abc919305b660cbf3a57828eaace))
* profiler info is available in production builds ([5649cc6](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5649cc69777a4a49f11cbce92e6f149d92b6e747))
* Remove Command shortcut for host mode ([#1168](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1168)) ([94eda38](https://github.com/MirrorNG/MirrorNG_Websocket/commit/94eda38803c141f279a5f42317c4d07c16b0223d))
* safer and consistent writers names ([#979](https://github.com/MirrorNG/MirrorNG_Websocket/issues/979)) ([b4077c1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b4077c1112a529ae7494709c1da0b6351d48c4b5))
* Script Templates ([#1217](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1217)) ([8cf6a07](https://github.com/MirrorNG/MirrorNG_Websocket/commit/8cf6a0707e0ada3d27b14ec55c4c5a082f0e214b))
* Secure messages that require authentication, fixes [#720](https://github.com/MirrorNG/MirrorNG_Websocket/issues/720) ([#1089](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1089)) ([7ac43cd](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7ac43cd56af6dd1b37f6696e97d7b671d6c21865))
* Semantic release for UPM ([#24](https://github.com/MirrorNG/MirrorNG_Websocket/issues/24)) ([8cbc005](https://github.com/MirrorNG/MirrorNG_Websocket/commit/8cbc005543a8b919ec022b2e9d1b5b8a6c85ef14))
* Server and Client share the same scene loading method ([#286](https://github.com/MirrorNG/MirrorNG_Websocket/issues/286)) ([acb6dd1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/acb6dd192244adcfab15d013a96c7402151d226b))
* Server attribute now throws error ([#270](https://github.com/MirrorNG/MirrorNG_Websocket/issues/270)) ([f3b5dc4](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f3b5dc4fef5fba05e585d274d9df05c3954ff6c7))
* Server raises an event when it starts ([#126](https://github.com/MirrorNG/MirrorNG_Websocket/issues/126)) ([d5b0a6f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d5b0a6f0dd65f9dbb6c4848bce5e81f93772a235))
* ship as a unitypackage ([11edc14](https://github.com/MirrorNG/MirrorNG_Websocket/commit/11edc142cfddfb7abecc11d8a12d6d32522ceb14))
* Show compile time error if overriding unused OnServerAddPlayer ([#682](https://github.com/MirrorNG/MirrorNG_Websocket/issues/682)) ([a8599c1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a8599c1af2b3b2abe377a580760cb13bbb3c9c7d))
* Spawn objects in clients in same order as server ([#247](https://github.com/MirrorNG/MirrorNG_Websocket/issues/247)) ([b786646](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b786646f1859bb0e1836460c6319a507e1cc31aa))
* spawning invalid object now gives exception ([e2fc829](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e2fc8292400aae8b3b8b972ff5824b8d9cdd6b88))
* support sending and receiving ArraySegment<byte> ([#898](https://github.com/MirrorNG/MirrorNG_Websocket/issues/898)) ([e5eecbf](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e5eecbff729f426e0de387f86fed70dc1c28b35a))
* support writing and reading array segments ([#918](https://github.com/MirrorNG/MirrorNG_Websocket/issues/918)) ([f9ff443](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f9ff44399ba42c3c7dbc4d4f2615ee4837aa6133))
* supports scriptable objects ([4b8f819](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4b8f8192123fe0b79ea71f2255a4bbac404c88b1))
* supports scriptable objects ([#1471](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1471)) ([0f10c72](https://github.com/MirrorNG/MirrorNG_Websocket/commit/0f10c72744864ac55d2e1aa96ba8d7713c77d9e7))
* Sync Events no longer need Event prefix ([#2087](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2087)) ([ed40c2d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ed40c2d210f174f1ed50b1e929e4fb161414f228))
* SyncDictionary can now be used for any IDictionary ([#703](https://github.com/MirrorNG/MirrorNG_Websocket/issues/703)) ([2683572](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2683572fb43cbe22c58d9994007ffebaf001fb4a))
* SyncList now supports any IList implementation ([#704](https://github.com/MirrorNG/MirrorNG_Websocket/issues/704)) ([040bcb4](https://github.com/MirrorNG/MirrorNG_Websocket/commit/040bcb45adbb4d7d2ad47c5c2e0275e7c05a7971))
* SyncList.FindIndex added ([#823](https://github.com/MirrorNG/MirrorNG_Websocket/issues/823)) ([b5ff43a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b5ff43ada3fa1ec39f88dd689117761bbefcdd0a))
* synclists has individual meaningful events ([#109](https://github.com/MirrorNG/MirrorNG_Websocket/issues/109)) ([e326064](https://github.com/MirrorNG/MirrorNG_Websocket/commit/e326064b51e8372726b30d19973df6293c74c376)), closes [#103](https://github.com/MirrorNG/MirrorNG_Websocket/issues/103)
* SyncSet and SyncDictionary now show in inspector ([#1561](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1561)) ([5510711](https://github.com/MirrorNG/MirrorNG_Websocket/commit/55107115c66ea38b75edf4a912b5cc48351128f7))
* SyncSet custom Equality Comparer support ([#1147](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1147)) ([0f95185](https://github.com/MirrorNG/MirrorNG_Websocket/commit/0f951858c553abd34be8544bf717744fae1d35c5))
* SyncToOwner now works with authority ([#1204](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1204)) ([92d0df7](https://github.com/MirrorNG/MirrorNG_Websocket/commit/92d0df7b399027ccd8f5983fc4bc4fea4530badc))
* TargetRpc no longer need Target prefix ([#2085](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2085)) ([d89ac9f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d89ac9fb052c17c2edfdf381aff35f70d23f4f0a))
* telepathy can now receive port from uri ([#1284](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1284)) ([06946cf](https://github.com/MirrorNG/MirrorNG_Websocket/commit/06946cf37fc2ed8660c93394d30632de3edc35db))
* throw exception if assigning incorrect asset id ([#250](https://github.com/MirrorNG/MirrorNG_Websocket/issues/250)) ([7741fb1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7741fb1f11abc8eb2aec8c1a94ac53380ac5a562))
* Time sync is now done per NetworkClient ([b24542f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b24542f62c6a2d0c43588af005f360ed74c619ca))
* transport can provide their preferred scheme ([774a07e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/774a07e1bf26cce964cf14d502b71b43ce4f5cd0))
* Transport can send to multiple connections at once ([#1120](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1120)) ([bc7e116](https://github.com/MirrorNG/MirrorNG_Websocket/commit/bc7e116a6e1e3f1a7dd326109631c8c8d12b2622))
* transports can give server uri ([#113](https://github.com/MirrorNG/MirrorNG_Websocket/issues/113)) ([dc700ec](https://github.com/MirrorNG/MirrorNG_Websocket/commit/dc700ec721cf4ecf6ddd082d88b933c9afffbc67))
* Transports can have multiple uri ([#292](https://github.com/MirrorNG/MirrorNG_Websocket/issues/292)) ([155a29c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/155a29c053421f870241a75427db748fbef08910))
* Transports can tell if they are supported ([#282](https://github.com/MirrorNG/MirrorNG_Websocket/issues/282)) ([890c6b8](https://github.com/MirrorNG/MirrorNG_Websocket/commit/890c6b8808ccbf4f4ffffae8c00a9d897ccac7e4))
* Transports may support any number of schemes ([#291](https://github.com/MirrorNG/MirrorNG_Websocket/issues/291)) ([2af7b9d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2af7b9d19cef3878147eee412adf2b9b32c91147))
* update upm package if tests pass ([#21](https://github.com/MirrorNG/MirrorNG_Websocket/issues/21)) ([7447776](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7447776a3bb47aa1e8f262671d62b48d52591247))
* Use logger framework for NetworkClient ([#1685](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1685)) ([6e92bf5](https://github.com/MirrorNG/MirrorNG_Websocket/commit/6e92bf5616d0d2486ce86497128094c4e33b5a3f))
* Use SortedDictionary for LogSettings ([#1914](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1914)) ([7d4c0a9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7d4c0a9cb6f24fa3c2834b9bf351e30dde88665f))
* user friendly weaver error ([#896](https://github.com/MirrorNG/MirrorNG_Websocket/issues/896)) ([954a3d5](https://github.com/MirrorNG/MirrorNG_Websocket/commit/954a3d594d53adba4fbea25193170760ed810ee8))
* Users may provide custom serializers for any type ([#1153](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1153)) ([9cb309e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9cb309e5bcb01ff3de4781e49d3a4f0a1227891b))
* Weaver can now automatically create Reader/Writer for types in a different assembly ([#1708](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1708)) ([b1644ae](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b1644ae481497d4347f404543c8200d2754617b9)), closes [#1570](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1570)
* websocket can receive port in url ([#1287](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1287)) ([c8ad118](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c8ad118d5065f2570c45914d8c1d6daeac2de7ef))
* Websockets now give client address, fix [#1121](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1121) ([#1125](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1125)) ([c9f317d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c9f317ddee092a59d2de8ad5988bea09a1ca152f))
* **scene:** Add support for scene loading params ([#644](https://github.com/MirrorNG/MirrorNG_Websocket/issues/644)) ([d48a375](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d48a3757dabe072002f93293fe9c7bcb13b1354d))
* **syncvar:** Add SyncDictionary ([#602](https://github.com/MirrorNG/MirrorNG_Websocket/issues/602)) ([7d21bde](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7d21bded9a521e53acc212b11a756d41e1b4218c))
* **telepathy:** Split MaxMessageSize to allow setting a different value for client and server ([#749](https://github.com/MirrorNG/MirrorNG_Websocket/issues/749)) ([f0a8b5d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f0a8b5dea817cf59d961643f409d2347349a1261))
* **websocket:** Re-enable native SSL ([#965](https://github.com/MirrorNG/MirrorNG_Websocket/issues/965)) ([7ed4a9a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7ed4a9a1e0727e067795ef7a9a24c6203f8ceb34))


### Performance Improvements

* Adding buffer for local connection ([#1621](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1621)) ([4d5cee8](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4d5cee893d0104c0070a0b1814c8c84f11f24f18))
* Adding dirty check before update sync var ([#1702](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1702)) ([58219c8](https://github.com/MirrorNG/MirrorNG_Websocket/commit/58219c8f726cd65f8987c9edd747987057967ea4))
* AddPlayerMessage is now a value type ([246a551](https://github.com/MirrorNG/MirrorNG_Websocket/commit/246a551151ea33892aa3bc04faca68c0b755a653))
* allocation free enumerator for syncsets,  fixes [#1171](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1171) ([#1173](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1173)) ([035e630](https://github.com/MirrorNG/MirrorNG_Websocket/commit/035e6307f98e3296f5d0f5c37eea5d4ce9c26fd0))
* allocation free syncdict foreach, fix [#1172](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1172) ([#1174](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1174)) ([1ec8910](https://github.com/MirrorNG/MirrorNG_Websocket/commit/1ec89105758cb6a76c438aa990c1dcfbf0a78af6))
* avoid allocation for error messages ([c669ff1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c669ff155df16a007ee69d703a1f72f2e0e0b919))
* Avoid allocation when reading message payload ([#912](https://github.com/MirrorNG/MirrorNG_Websocket/issues/912)) ([11750a9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/11750a9e7a3f330e508642d1fca51173c3a4d5a8))
* avoid allocation with message structs ([#939](https://github.com/MirrorNG/MirrorNG_Websocket/issues/939)) ([7c7c910](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7c7c910a5e5ce15dc81b1008e4797222abe7fd9a))
* avoid boxing for getting message id ([#1144](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1144)) ([9513842](https://github.com/MirrorNG/MirrorNG_Websocket/commit/95138427f3c6765ba25bccc98968f477c1f8bcda))
* avoid boxing if there is no profiler ([a351879](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a351879f910be15492d498b3cc38e2ea8861d231))
* ClientAuthorityMessage is now a value type ([#991](https://github.com/MirrorNG/MirrorNG_Websocket/issues/991)) ([d071438](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d071438d01080b56065e800c3ddf492c87231ed6))
* Custom IEnumerator for SyncLists to avoid allocations on foreach ([#904](https://github.com/MirrorNG/MirrorNG_Websocket/issues/904)) ([4ffd5a2](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4ffd5a2e06849fc812106f67d5d2b9c3d40a99b9))
* don't varint bytes and shorts ([4867415](https://github.com/MirrorNG/MirrorNG_Websocket/commit/48674151f01c040979e4a9aebbf3f6037f7b2226))
* eliminate boxing with lists ([#901](https://github.com/MirrorNG/MirrorNG_Websocket/issues/901)) ([8f6d4cb](https://github.com/MirrorNG/MirrorNG_Websocket/commit/8f6d4cb22e0417bb0de1cb744e307250298e20f4))
* eliminate small allocation on remote calls ([#907](https://github.com/MirrorNG/MirrorNG_Websocket/issues/907)) ([1c18743](https://github.com/MirrorNG/MirrorNG_Websocket/commit/1c18743788be9d051fa617345e463cf0df6e38d8))
* eliminate string concat during remote method calls ([#908](https://github.com/MirrorNG/MirrorNG_Websocket/issues/908)) ([70a532b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/70a532b5db7cd0c20797b1168d84c6368480450c))
* empty messages are value types now ([145edaa](https://github.com/MirrorNG/MirrorNG_Websocket/commit/145edaa50bd225db9f1442aa7c86bae13daa6388))
* faster NetworkReader pooling ([#1623](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1623)) ([1ae0381](https://github.com/MirrorNG/MirrorNG_Websocket/commit/1ae038172ac7f5e18e0e09b0081f7f42fa0eff7a))
* faster NetworkWriter pooling ([#1620](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1620)) ([4fa43a9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4fa43a947132f89e5348c63e393dd3b80e1fe7e1))
* Increasing Network Writer performance ([#1674](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1674)) ([f057983](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f0579835ca52270de424e81691f12c02022c3909))
* messages should be value types ([#987](https://github.com/MirrorNG/MirrorNG_Websocket/issues/987)) ([633fb19](https://github.com/MirrorNG/MirrorNG_Websocket/commit/633fb19f8d0f29eef2fd96a97c4da32203cb3408))
* MultiplexTransport: avoid Linq allocations that would happen on every packet send because Send calls .ServerActive() each time ([7fe8888](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7fe8888df5a74667914c66c336625309279ff28a))
* NetworkProximityChecker checks Server.connections instead of doing 10k sphere casts for 10k monsters. 2k NetworkTransforms demo is significantly faster. Stable 80fps instead of 500ms freezes in between. ([#1852](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1852)) ([2d89f05](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2d89f059afd9175dd7e6d81a0e2e38c0a28915c8))
* Networkreader nonalloc ([#910](https://github.com/MirrorNG/MirrorNG_Websocket/issues/910)) ([18f035d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/18f035d268d5c84fb6b34d2836b188692cd5a96c))
* objdestroy message is now a value type ([#993](https://github.com/MirrorNG/MirrorNG_Websocket/issues/993)) ([a32c5a9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a32c5a945689285241cadb809b24c2883ac6078c))
* ObjHideMessage is now a value type ([#992](https://github.com/MirrorNG/MirrorNG_Websocket/issues/992)) ([a49d938](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a49d938fbe3c27f7237705dae3b2a2d21114de81))
* OnDeserializeSafely without GC ([#804](https://github.com/MirrorNG/MirrorNG_Websocket/issues/804)) ([27b7e25](https://github.com/MirrorNG/MirrorNG_Websocket/commit/27b7e250a0451ae6a04222a9d035a5b0efdbeb99))
* Optimize interest management ([f1ceb0c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f1ceb0c7a0438d3b7febbccc1ab8fde0a7e2580b))
* Optimize interest management ([#899](https://github.com/MirrorNG/MirrorNG_Websocket/issues/899)) ([ff1a234](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ff1a2346b4b28acef7054f5e460e4b863dec6372))
* Pack small 32 bit negatives efficiently ([480af1a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/480af1aa6c8aca96b67f1532994c5d7d2d8902c5))
* Pack small 64 bit negatives efficiently ([5f1ef4a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5f1ef4ab1f5a895e4537dcb5b928b557487c5e60))
* Recycle argument writer to avoid allocations ([#945](https://github.com/MirrorNG/MirrorNG_Websocket/issues/945)) ([9743216](https://github.com/MirrorNG/MirrorNG_Websocket/commit/97432169ead1e212bff4496ac2f1afe1c7ad2898))
* Reduce enum bandwidth ([#794](https://github.com/MirrorNG/MirrorNG_Websocket/issues/794)) ([97e9ac2](https://github.com/MirrorNG/MirrorNG_Websocket/commit/97e9ac24830b1e0e0aec28c8608ad630ed024f5c))
* remove allocations during syncvar sync ([#946](https://github.com/MirrorNG/MirrorNG_Websocket/issues/946)) ([d2381ce](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d2381ce892968a91405afd52f00a357144817539))
* remove BinaryWriter,  it allocates like crazy ([#929](https://github.com/MirrorNG/MirrorNG_Websocket/issues/929)) ([7b3e82a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7b3e82a1fc4339698583633b00b9ed052780f6ed))
* remove network transform allocation ([9e3ecc1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9e3ecc1cedc5239d30e91bcdcff9841b94e3dec8))
* Remove redundant mask ([#1604](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1604)) ([5d76afb](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5d76afbe29f456a657c9e1cb7c97435242031091))
* remove syncvar boxing ([#927](https://github.com/MirrorNG/MirrorNG_Websocket/issues/927)) ([b2ba589](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b2ba5896fa6b58fa524e6cde1b763ef6f3cba4b3))
* replace isValueType with faster alternative ([#1617](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1617)) ([61163ca](https://github.com/MirrorNG/MirrorNG_Websocket/commit/61163cacb4cb2652aa8632f84be89212674436ff)), closes [/github.com/vis2k/Mirror/issues/1614#issuecomment-605443808](https://github.com//github.com/vis2k/Mirror/issues/1614/issues/issuecomment-605443808)
* return the contents of the writer as an array segment ([#916](https://github.com/MirrorNG/MirrorNG_Websocket/issues/916)) ([ced3690](https://github.com/MirrorNG/MirrorNG_Websocket/commit/ced36906bcb6dca2a1edb439da6b00d0b5d0d09d))
* reuse the network writer used for rpc parameters ([5dafc4d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5dafc4d932584710c4fec62b9bfb52cedd7f02fb))
* rpc messages are now value types ([#997](https://github.com/MirrorNG/MirrorNG_Websocket/issues/997)) ([b5b2f3e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b5b2f3e1eb8c64d54cd322e095c42a224dad0f1a))
* SceneMessage is now a value type ([#989](https://github.com/MirrorNG/MirrorNG_Websocket/issues/989)) ([407b36a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/407b36acb724cbf90737465e9faf4918d0cee345))
* simplify and speed up getting methods in weaver ([c1cfc42](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c1cfc421811e4c12e84cb28677ac68c82575958d))
* spawn with client authority only takes 1 message ([#1206](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1206)) ([3b9414f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/3b9414f131450e5f96c621f57d9e061dbda62661))
* SpawnPrefabMessage is now a value type ([a44efd1](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a44efd1f92b66cbf7325830463e7e310dabe3fd8))
* SpawnSceneObjectMessage is now a value type ([40c7d97](https://github.com/MirrorNG/MirrorNG_Websocket/commit/40c7d97ed99fe7a478b74d1530b70fbc2ae3cfa9))
* Transports now give ArraySegment<byte> instead of byte[] (based on [#569](https://github.com/MirrorNG/MirrorNG_Websocket/issues/569) and [#846](https://github.com/MirrorNG/MirrorNG_Websocket/issues/846)) ([77bee45](https://github.com/MirrorNG/MirrorNG_Websocket/commit/77bee450b91661e9f3902a30e0749cf6c786020c))
* update vars is now a value type ([#990](https://github.com/MirrorNG/MirrorNG_Websocket/issues/990)) ([f99e71e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f99e71ebdfe2fdf50116270618a5bf0f2b97b748))
* Use 0 for null byte arrays ([#925](https://github.com/MirrorNG/MirrorNG_Websocket/issues/925)) ([21ca49d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/21ca49d1be9a15445baf1f7417d7fc6ec1df1053))
* use 0 for null strings ([#926](https://github.com/MirrorNG/MirrorNG_Websocket/issues/926)) ([7181cd9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7181cd9ca190a5f3eb45ec7878492479db55d9f3))
* use bitshift operations instead of division in varint ([fff765c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/fff765c96be0c61d77ade8f5c12997e709ab3d89))
* use byte[] directly instead of MemoryStream ([#1618](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1618)) ([166b8c9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/166b8c946736447a76c1886c4d1fb036f6e56e20))
* Use continuewith to queue up ssl messages ([#1640](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1640)) ([84b2c8c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/84b2c8cf2671728baecf734487ddaa7fab9943a0))
* Use invokeRepeating instead of Update ([#2066](https://github.com/MirrorNG/MirrorNG_Websocket/issues/2066)) ([264f9b8](https://github.com/MirrorNG/MirrorNG_Websocket/commit/264f9b8f945f0294a8420202abcd0c80e27e6ee6))
* Use NetworkWriterPool in NetworkAnimator ([#1421](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1421)) ([7d472f2](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7d472f21f9a807357df244a3f0ac259dd431661f))
* Use NetworkWriterPool in NetworkTransform ([#1422](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1422)) ([a457845](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a4578458a15e3d2840a49dd029b4c404cadf85a4))
* Use RemoveAt to remove elements from lists ([22b45f7](https://github.com/MirrorNG/MirrorNG_Websocket/commit/22b45f7a11be6f3c09e49a302506b540c1c5adc6))
* use value types for empty messages ([#988](https://github.com/MirrorNG/MirrorNG_Websocket/issues/988)) ([81d915e](https://github.com/MirrorNG/MirrorNG_Websocket/commit/81d915eb7350878f69db2f579355ad1224359194))
* Use WritePackedUInt32 in SyncList ([#688](https://github.com/MirrorNG/MirrorNG_Websocket/issues/688)) ([2db7576](https://github.com/MirrorNG/MirrorNG_Websocket/commit/2db7576bbc163cf53e1b28384972361e3ca4a720))


* remove NetworkConnection.isAuthenticated (#167) ([8a0e0b3](https://github.com/MirrorNG/MirrorNG_Websocket/commit/8a0e0b3af37e8b0c74a8b97f12ec29cf202715ea)), closes [#167](https://github.com/MirrorNG/MirrorNG_Websocket/issues/167)
* Simplify RegisterHandler (#160) ([f4f5167](https://github.com/MirrorNG/MirrorNG_Websocket/commit/f4f516791b8390f0babf8a7aefa19254427d4145)), closes [#160](https://github.com/MirrorNG/MirrorNG_Websocket/issues/160)
* Remove NetworkConnectionToClient (#155) ([bd95cea](https://github.com/MirrorNG/MirrorNG_Websocket/commit/bd95cea4d639753335b21c48781603acd758a9e7)), closes [#155](https://github.com/MirrorNG/MirrorNG_Websocket/issues/155)
* remove room feature for now (#122) ([87dd495](https://github.com/MirrorNG/MirrorNG_Websocket/commit/87dd495a6fca6c85349afd42ba6449d98de1f567)), closes [#122](https://github.com/MirrorNG/MirrorNG_Websocket/issues/122)
* Server Disconnect is now an event not a message (#121) ([82ebd71](https://github.com/MirrorNG/MirrorNG_Websocket/commit/82ebd71456cbd2e819540d961a93814c57735784)), closes [#121](https://github.com/MirrorNG/MirrorNG_Websocket/issues/121)
* remove OnClientStart virtual ([eb5242d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/eb5242d63fa011381e7692470713fd144476454a))
* Move on client stop (#118) ([678e386](https://github.com/MirrorNG/MirrorNG_Websocket/commit/678e3867a9f232e52d2a6cdbfae8140b0e82bd11)), closes [#118](https://github.com/MirrorNG/MirrorNG_Websocket/issues/118)
* merge clientscene and networkclient (#84) ([dee1046](https://github.com/MirrorNG/MirrorNG_Websocket/commit/dee10460325119337401dc4d237dec8bfb9ddb29)), closes [#84](https://github.com/MirrorNG/MirrorNG_Websocket/issues/84)
* removed obsoletes (#1542) ([4faec29](https://github.com/MirrorNG/MirrorNG_Websocket/commit/4faec295593b81a709a57aaf374bb5b080a04538)), closes [#1542](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1542)
* Assign/Remove client authority now throws exception ([7679d3b](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7679d3bef369de5245fd301b33e85dbdd74e84cd))
* Removed LLAPI ([b0c936c](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b0c936cb7d1a803b7096806a905a4c121e45bcdf))
* Simplify unpacking messages (#65) ([c369da8](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c369da84dc34dbbde68a7b30758a6a14bc2573b1)), closes [#65](https://github.com/MirrorNG/MirrorNG_Websocket/issues/65)
* Remove all compiler defines ([a394345](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a3943459598d30a325fb1e1315b84c0dedf1741c))
* Simplify AddPlayerForConnection (#62) ([fb26755](https://github.com/MirrorNG/MirrorNG_Websocket/commit/fb267557af292e048df248d4f85fff3569ac2963)), closes [#62](https://github.com/MirrorNG/MirrorNG_Websocket/issues/62)
* Renamed localEulerAnglesSensitivity (#1474) ([eee9692](https://github.com/MirrorNG/MirrorNG_Websocket/commit/eee969201d69df1e1ee1f1623b55a78f6003fbb1)), closes [#1474](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1474)
* Rename NetworkServer.localClientActive ([7cd0894](https://github.com/MirrorNG/MirrorNG_Websocket/commit/7cd0894853b97fb804ae15b8a75b75c9d7bc04a7))
* Simplify spawning ([c87a38a](https://github.com/MirrorNG/MirrorNG_Websocket/commit/c87a38a4ff0c350901138b90db7fa8e61b1ab7db))
* Merge pull request #650 from vis2k/networkclient_static_2 ([fac0542](https://github.com/MirrorNG/MirrorNG_Websocket/commit/fac05428cc7f49f53d2322a010d61b61349241ef)), closes [#650](https://github.com/MirrorNG/MirrorNG_Websocket/issues/650)


### Reverts

* Revert "Revert "Explain why 10"" ([d727e4f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/d727e4fd4b9e811025c7309efeba090e3ac14ccd))
* Revert "Revert "perf: faster NetworkWriter pooling (#1616)"" ([20e9e5d](https://github.com/MirrorNG/MirrorNG_Websocket/commit/20e9e5dab0dfb8a67d11d84152b0580ea5370551)), closes [#1616](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1616)
* Revert "fix: replacing the player does not mean giving up authority (#1254)" ([b8618d3](https://github.com/MirrorNG/MirrorNG_Websocket/commit/b8618d356f0eeb7aa7bde5ea41c56d7a2cdb3373)), closes [#1254](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1254)
* Revert "feat: Add Timeout to NetworkAuthenticator (#1091)" ([12c5a8f](https://github.com/MirrorNG/MirrorNG_Websocket/commit/12c5a8fdc30280b9ad113c3a8116b2d046d3b31f)), closes [#1091](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1091)
* Revert "Remove add component from deprecated components (#1087)" ([9f09c21](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9f09c216807271e5fc89aa441fa95af0b0eaf80c)), closes [#1087](https://github.com/MirrorNG/MirrorNG_Websocket/issues/1087)
* Revert "Inserted blank lines where appropriate" ([913d503](https://github.com/MirrorNG/MirrorNG_Websocket/commit/913d503fdade774e668ceb43d9397b86870d99cd))
* Revert "feat: Custom readers and writers" ([07ef8c9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/07ef8c91c0931628adb589b67893a80145134c15))
* Revert "New Basic Example (#985)" ([35b9919](https://github.com/MirrorNG/MirrorNG_Websocket/commit/35b9919d91a9b942b133426eed0d45733f48cd6b)), closes [#985](https://github.com/MirrorNG/MirrorNG_Websocket/issues/985)
* Revert "fix: reduce allocations at the transport" ([bb128fe](https://github.com/MirrorNG/MirrorNG_Websocket/commit/bb128fe3b5f05becaf7ea0546c9198707d2c76ba))
* Revert "doc: messages can be struct now" ([79f7c81](https://github.com/MirrorNG/MirrorNG_Websocket/commit/79f7c815207e18e35fddf9c2e528178eb88decd9))
* Revert "ClientScene.OnSpawnPrefab and NetworkManager.OnServerAddPlayerInternal: spawn objects with prefab names to avoid unnecessary "(Clone)" suffix from Unity. otherwise we need a name sync component in all games that show the names, e.g. MMOs for all monsters. This way we only need name sync components for objects that actually do change names, e.g. players." because of issue #426 ([82d4cf0](https://github.com/MirrorNG/MirrorNG_Websocket/commit/82d4cf08ff187c002d5ddf04b7b88d72709b3a44)), closes [#426](https://github.com/MirrorNG/MirrorNG_Websocket/issues/426)
* Revert "Source based weaver (#319)" ([9b232b0](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9b232b05517bc215e005a333aafcb92cdb832d60)), closes [#319](https://github.com/MirrorNG/MirrorNG_Websocket/issues/319)
* Revert "Code style and comment typo fix." (#386) ([dc3b767](https://github.com/MirrorNG/MirrorNG_Websocket/commit/dc3b767743309c414b5e88ba3443f82b93dab0e2)), closes [#386](https://github.com/MirrorNG/MirrorNG_Websocket/issues/386)
* Revert "Onserialize improvements (#302)" ([00a3610](https://github.com/MirrorNG/MirrorNG_Websocket/commit/00a36109a0a0ebad860a0f37245a22de3cd05f70)), closes [#302](https://github.com/MirrorNG/MirrorNG_Websocket/issues/302)
* Revert "Documented the attributes." ([9e3dcc7](https://github.com/MirrorNG/MirrorNG_Websocket/commit/9e3dcc7acdded4980b5ccef3a3b3104e9c27d80a))
* Revert "Documented NetworkBehaviour and NetworkIdentity." ([a5cfc81](https://github.com/MirrorNG/MirrorNG_Websocket/commit/a5cfc810dbddb7aabada07c0200d0d52f743a2d6))
* Revert "Documented NetworkManager." ([5bc44a9](https://github.com/MirrorNG/MirrorNG_Websocket/commit/5bc44a97398a476139ef4aebcdf024921b8d1f18))
* Revert "Don't generate OnSerialize/OnDeserialize if not needed (#199)" (#217) ([40a3ecc](https://github.com/MirrorNG/MirrorNG_Websocket/commit/40a3ecce083e021adaeb56daf2653fb89a0e08b0)), closes [#199](https://github.com/MirrorNG/MirrorNG_Websocket/issues/199) [#217](https://github.com/MirrorNG/MirrorNG_Websocket/issues/217)
* Revert "Don't require Cmd, Rpc and Target prefixes (#127)" ([96992c3](https://github.com/MirrorNG/MirrorNG_Websocket/commit/96992c35bce04c07c4cbdd29c7ea534dc096fdc7)), closes [#127](https://github.com/MirrorNG/MirrorNG_Websocket/issues/127)


### BREAKING CHANGES

* rename AsyncMultiplexTransport -> MultiplexTransport
* rename AsyncFallbackTransport -> FallbackTransport
* rename AsyncWsTransport -> WsTransport
* [LocalPlayerCallback] is now [LocalPlayer(error = false)]

* Local Player guard

Co-authored-by: Paul Pacheco <paul.pacheco@aa.com>
* [ClientCallback] is now [Client(error = false)]
* [HasAuthorityCallback] is now [HasAuthority(error = false)]

* fix test

Co-authored-by: Paul Pacheco <paul.pacheco@aa.com>
* [ServerCallback] is now [Server(error = false)]

* fixed weaver test

* Remove unused code

* fix comment

* document replacement of ServerCallback

* No need to be serializable

* Exception should be serializable?

* Fix code smell

* No need to implement interface,  parent does

Co-authored-by: Paul Pacheco <paul.pacheco@aa.com>
* Renamed [Command] to [ServerRpc]
* NetworkManager no longer handles scene changes
* Remove isAuthenticated

* Fix typo

* Fix smells

* Remove smells
* NetworkConneciton.RegisterHandler only needs message class
* NetworkConnectionToClient and networkConnectionToServer are gone
* connecition Id is gone
* websocket transport does not work,  needs to be replaced.
* NetworkManager no longer has OnServerStart virtual
* NetworkManager no longer spawns the player.  You need to add PlayerSpawner component if you want that behavior
* You will need to reassign your scenes after upgrade

* Automatically fix properties that were using name

If you open a NetworkManager or other gameobject that uses a scene name
it now gets converted to scene path by the SceneDrawer

* Use get scene by name

* Scene can never be null

* Update Assets/Mirror/Examples/AdditiveScenes/Scenes/MainScene.unity

* Issue warning if we drop the scene

* Issue error if scene is lost

* Add suggestion on how to fix the error

* Keep backwards compatibility, check for scene name

* cache the active scene

* Update Assets/Mirror/Editor/SceneDrawer.cs

Co-Authored-By: James Frowen <jamesfrowendev@gmail.com>

* GetSceneByName only works if scene is loaded

* Remove unused using

Co-authored-by: James Frowen <jamesfrowendev@gmail.com>
* Room feature and example are gone
* offline/online scenes are gone
* OnServerDisconnect is gone
* Removed OnStartClient virtual,  use event from NetworkClient instead
* OnStopClient virtual is replaced by event in Client
* SyncDictionary callback has been replaced
* callback signature changed in SyncSet
* Sync lists no longer have a Callback event with an operation enum
* NetworkBehavior no longer has virtuals for lifecycle events
* ClientScene is gone
* removed obsoletes
* NetworkTime.Time is no longer static
* observers is now a set of connections, not a dictionary
* cannot pass GameObjects and NetworkIdentities anymore.
Will be restored in the future.
* StartClient now receives the server ip
* NetworkManager no longer has NetworkAddress
* Assign/Remove client authority throws exception instead of returning boolean
* Removed LLAPITransport
* MessagePacker.UnpackMessage replaced by UnpackId
* removed compilation defines,  use upm version defines instead
* AddPlayerForConnection no longer receives the client

* fix compilatio errors

* fix build errors
* ClientConnect replaced with ClientConnectAsync
that can be awaited

* fix: TCP transport for async compliance

* use async connect

* Ignore telepathy tests until they are fixed

* It is ok to interrupt sockets

* Remove some warnings

* Remove some warnings

* Remove some warnings

* Remove some warnings

* Remove some warnings

* Remove some warnings

* Remove some warnings
* localEulerAnglesSensitivity renamed to localRotationSensitivity
* Make the server uri method mandatory in transports

Co-authored-by: MrGadget <chris@clevertech.net>
* rename localClientActive to LocalClientActive
* Spawn no longer receives NetworkClient
* Remove obsolete OnServerAddPlayer

Any person that overrides this method has a broken game.  These methods are never called anywhere.

The user gets a warning because they are overriding an obsolete method,  which might get ignored if they have lots of other warnings.   They would run their game and their game would not work at all.  No errors.

By removing these methods, users that override these methods will get a compile time error instead.  So they cannot ignore this error and they will fix it.

* Method is no longer available in NetworkLobbyManager
* Make NetworkClient Great Again!
