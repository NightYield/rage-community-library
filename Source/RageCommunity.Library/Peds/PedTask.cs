namespace RageCommunity.Library.Peds
{
	/// <summary>
	/// Defines identifiers that represent the <see cref="Rage.Ped"/> task
	/// </summary>
	/// <remarks>
	/// Courtesy of <a href="https://alloc8or.re/gta5/doc/enums/eTaskTypeIndex.txt">Alloc8or.re</a>
	/// </remarks>
	public enum PedTask
	{
		/// <summary>
		/// Represents the Task "CTaskHandsUp".
		/// </summary>
		HandsUp = 0,
		/// <summary>
		/// Represents the Task "CTaskClimbLadder".
		/// </summary>
		ClimbLadder = 1,
		/// <summary>
		/// Represents the Task "CTaskExitVehicle".
		/// </summary>
		ExitVehicle = 2,
		/// <summary>
		/// Represents the Task "CTaskCombatRoll".
		/// </summary>
		CombatRoll = 3,
		/// <summary>
		/// Represents the Task "CTaskAimGunOnFoot".
		/// </summary>
		AimGunOnFoot = 4,
		/// <summary>
		/// Represents the Task "CTaskMovePlayer".
		/// </summary>
		MovePlayer = 5,
		/// <summary>
		/// Represents the Task "CTaskPlayerOnFoot".
		/// </summary>
		PlayerOnFoot = 6,
		/// <summary>
		/// Represents the Task "CTaskWeapon".
		/// </summary>
		Weapon = 8,
		/// <summary>
		/// Represents the Task "CTaskPlayerWeapon".
		/// </summary>
		PlayerWeapon = 9,
		/// <summary>
		/// Represents the Task "CTaskPlayerIdles".
		/// </summary>
		PlayerIdles = 10,
		/// <summary>
		/// Represents the Task "CTaskAimGun".
		/// </summary>
		AimGun = 12,
		/// <summary>
		/// Represents the Task "CTaskComplex".
		/// </summary>
		Complex = 12,
		/// <summary>
		/// Represents the Task "CTaskFSMClone".
		/// </summary>
		FSMClone = 12,
		/// <summary>
		/// Represents the Task "CTaskMotionBase".
		/// </summary>
		MotionBase = 12,
		/// <summary>
		/// Represents the Task "CTaskMove".
		/// </summary>
		Move = 12,
		/// <summary>
		/// Represents the Task "CTaskMoveBase".
		/// </summary>
		MoveBase = 12,
		/// <summary>
		/// Represents the Task "CTaskNMBehaviour".
		/// </summary>
		NMBehaviour = 12,
		/// <summary>
		/// Represents the Task "CTaskNavBase".
		/// </summary>
		NavBase = 12,
		/// <summary>
		/// Represents the Task "CTaskScenario".
		/// </summary>
		Scenario = 12,
		/// <summary>
		/// Represents the Task "CTaskSearchBase".
		/// </summary>
		SearchBase = 12,
		/// <summary>
		/// Represents the Task "CTaskSearchInVehicleBase".
		/// </summary>
		SearchInVehicleBase = 12,
		/// <summary>
		/// Represents the Task "CTaskShockingEvent".
		/// </summary>
		ShockingEvent = 12,
		/// <summary>
		/// Represents the Task "CTaskTrainBase".
		/// </summary>
		TrainBase = 12,
		/// <summary>
		/// Represents the Task "CTaskVehicleFSM".
		/// </summary>
		VehicleFSM = 12,
		/// <summary>
		/// Represents the Task "CTaskVehicleGoTo".
		/// </summary>
		VehicleGoTo = 12,
		/// <summary>
		/// Represents the Task "CTaskVehicleMissionBase".
		/// </summary>
		VehicleMissionBase = 12,
		/// <summary>
		/// Represents the Task "CTaskVehicleTempAction".
		/// </summary>
		VehicleTempAction = 12,
		/// <summary>
		/// Represents the Task "CTaskPause".
		/// </summary>
		Pause = 14,
		/// <summary>
		/// Represents the Task "CTaskDoNothing".
		/// </summary>
		DoNothing = 15,
		/// <summary>
		/// Represents the Task "CTaskGetUp".
		/// </summary>
		GetUp = 16,
		/// <summary>
		/// Represents the Task "CTaskGetUpAndStandStill".
		/// </summary>
		GetUpAndStandStill = 17,
		/// <summary>
		/// Represents the Task "CTaskFallOver".
		/// </summary>
		FallOver = 18,
		/// <summary>
		/// Represents the Task "CTaskFallAndGetUp".
		/// </summary>
		FallAndGetUp = 19,
		/// <summary>
		/// Represents the Task "CTaskCrawl".
		/// </summary>
		Crawl = 20,
		/// <summary>
		/// Represents the Task "CTaskComplexOnFire".
		/// </summary>
		ComplexOnFire = 25,
		/// <summary>
		/// Represents the Task "CTaskDamageElectric".
		/// </summary>
		DamageElectric = 26,
		/// <summary>
		/// Represents the Task "CTaskTriggerLookAt".
		/// </summary>
		TriggerLookAt = 28,
		/// <summary>
		/// Represents the Task "CTaskClearLookAt".
		/// </summary>
		ClearLookAt = 29,
		/// <summary>
		/// Represents the Task "CTaskSetCharDecisionMaker".
		/// </summary>
		SetCharDecisionMaker = 30,
		/// <summary>
		/// Represents the Task "CTaskSetPedDefensiveArea".
		/// </summary>
		SetPedDefensiveArea = 31,
		/// <summary>
		/// Represents the Task "CTaskUseSequence".
		/// </summary>
		UseSequence = 32,
		/// <summary>
		/// Represents the Task "CTaskMoveStandStill".
		/// </summary>
		MoveStandStill = 34,
		/// <summary>
		/// Represents the Task "CTaskComplexControlMovement".
		/// </summary>
		ComplexControlMovement = 35,
		/// <summary>
		/// Represents the Task "CTaskMoveSequence".
		/// </summary>
		MoveSequence = 36,
		/// <summary>
		/// Represents the Task "CTaskAmbientClips".
		/// </summary>
		AmbientClips = 38,
		/// <summary>
		/// Represents the Task "CTaskMoveInAir".
		/// </summary>
		MoveInAir = 39,
		/// <summary>
		/// Represents the Task "CTaskNetworkClone".
		/// </summary>
		NetworkClone = 40,
		/// <summary>
		/// Represents the Task "CTaskUseClimbOnRoute".
		/// </summary>
		UseClimbOnRoute = 41,
		/// <summary>
		/// Represents the Task "CTaskUseDropDownOnRoute".
		/// </summary>
		UseDropDownOnRoute = 42,
		/// <summary>
		/// Represents the Task "CTaskUseLadderOnRoute".
		/// </summary>
		UseLadderOnRoute = 43,
		/// <summary>
		/// Represents the Task "CTaskSetBlockingOfNonTemporaryEvents".
		/// </summary>
		SetBlockingOfNonTemporaryEvents = 44,
		/// <summary>
		/// Represents the Task "CTaskForceMotionState".
		/// </summary>
		ForceMotionState = 45,
		/// <summary>
		/// Represents the Task "CTaskSlopeScramble".
		/// </summary>
		SlopeScramble = 46,
		/// <summary>
		/// Represents the Task "CTaskGoToAndClimbLadder".
		/// </summary>
		GoToAndClimbLadder = 47,
		/// <summary>
		/// Represents the Task "CTaskClimbLadderFully".
		/// </summary>
		ClimbLadderFully = 48,
		/// <summary>
		/// Represents the Task "CTaskRappel".
		/// </summary>
		Rappel = 49,
		/// <summary>
		/// Represents the Task "CTaskVault".
		/// </summary>
		Vault = 50,
		/// <summary>
		/// Represents the Task "CTaskDropDown".
		/// </summary>
		DropDown = 51,
		/// <summary>
		/// Represents the Task "CTaskAffectSecondaryBehaviour".
		/// </summary>
		AffectSecondaryBehaviour = 52,
		/// <summary>
		/// Represents the Task "CTaskAmbientLookAtEvent".
		/// </summary>
		AmbientLookAtEvent = 53,
		/// <summary>
		/// Represents the Task "CTaskOpenDoor".
		/// </summary>
		OpenDoor = 54,
		/// <summary>
		/// Represents the Task "CTaskShovePed".
		/// </summary>
		ShovePed = 55,
		/// <summary>
		/// Represents the Task "CTaskSwapWeapon".
		/// </summary>
		SwapWeapon = 56,
		/// <summary>
		/// Represents the Task "CTaskGeneralSweep".
		/// </summary>
		GeneralSweep = 57,
		/// <summary>
		/// Represents the Task "CTaskPolice".
		/// </summary>
		Police = 58,
		/// <summary>
		/// Represents the Task "CTaskPoliceOrderResponse".
		/// </summary>
		PoliceOrderResponse = 59,
		/// <summary>
		/// Represents the Task "CTaskPursueCriminal".
		/// </summary>
		PursueCriminal = 60,
		/// <summary>
		/// Represents the Task "CTaskArrestPed".
		/// </summary>
		ArrestPed = 62,
		/// <summary>
		/// Represents the Task "CTaskArrestPed2".
		/// </summary>
		ArrestPed2 = 63,
		/// <summary>
		/// Represents the Task "CTaskBusted".
		/// </summary>
		Busted = 64,
		/// <summary>
		/// Represents the Task "CTaskFirePatrol".
		/// </summary>
		FirePatrol = 65,
		/// <summary>
		/// Represents the Task "CTaskHeliOrderResponse".
		/// </summary>
		HeliOrderResponse = 66,
		/// <summary>
		/// Represents the Task "CTaskHeliPassengerRappel".
		/// </summary>
		HeliPassengerRappel = 67,
		/// <summary>
		/// Represents the Task "CTaskAmbulancePatrol".
		/// </summary>
		AmbulancePatrol = 68,
		/// <summary>
		/// Represents the Task "CTaskPoliceWantedResponse".
		/// </summary>
		PoliceWantedResponse = 69,
		/// <summary>
		/// Represents the Task "CTaskSwat".
		/// </summary>
		Swat = 70,
		/// <summary>
		/// Represents the Task "CTaskSwatWantedResponse".
		/// </summary>
		SwatWantedResponse = 72,
		/// <summary>
		/// Represents the Task "CTaskSwatOrderResponse".
		/// </summary>
		SwatOrderResponse = 73,
		/// <summary>
		/// Represents the Task "CTaskSwatGoToStagingArea".
		/// </summary>
		SwatGoToStagingArea = 74,
		/// <summary>
		/// Represents the Task "CTaskSwatFollowInLine".
		/// </summary>
		SwatFollowInLine = 75,
		/// <summary>
		/// Represents the Task "CTaskWitness".
		/// </summary>
		Witness = 76,
		/// <summary>
		/// Represents the Task "CTaskGangPatrol".
		/// </summary>
		GangPatrol = 77,
		/// <summary>
		/// Represents the Task "CTaskArmy".
		/// </summary>
		Army = 78,
		/// <summary>
		/// Represents the Task "CTaskShockingEventWatch".
		/// </summary>
		ShockingEventWatch = 80,
		/// <summary>
		/// Represents the Task "CTaskShockingEventGoto".
		/// </summary>
		ShockingEventGoto = 82,
		/// <summary>
		/// Represents the Task "CTaskShockingEventHurryAway".
		/// </summary>
		ShockingEventHurryAway = 83,
		/// <summary>
		/// Represents the Task "CTaskShockingEventReactToAircraft".
		/// </summary>
		ShockingEventReactToAircraft = 84,
		/// <summary>
		/// Represents the Task "CTaskShockingEventReact".
		/// </summary>
		ShockingEventReact = 85,
		/// <summary>
		/// Represents the Task "CTaskShockingEventBackAway".
		/// </summary>
		ShockingEventBackAway = 86,
		/// <summary>
		/// Represents the Task "CTaskShockingPoliceInvestigate".
		/// </summary>
		ShockingPoliceInvestigate = 87,
		/// <summary>
		/// Represents the Task "CTaskShockingEventStopAndStare".
		/// </summary>
		ShockingEventStopAndStare = 88,
		/// <summary>
		/// Represents the Task "CTaskShockingNiceCarPicture".
		/// </summary>
		ShockingNiceCarPicture = 89,
		/// <summary>
		/// Represents the Task "CTaskShockingEventThreatResponse".
		/// </summary>
		ShockingEventThreatResponse = 90,
		/// <summary>
		/// Represents the Task "CTaskTakeOffHelmet".
		/// </summary>
		TakeOffHelmet = 92,
		/// <summary>
		/// Represents the Task "CTaskCarReactToVehicleCollision".
		/// </summary>
		CarReactToVehicleCollision = 93,
		/// <summary>
		/// Represents the Task "CTaskCarReactToVehicleCollisionGetOut".
		/// </summary>
		CarReactToVehicleCollisionGetOut = 95,
		/// <summary>
		/// Represents the Task "CTaskDyingDead".
		/// </summary>
		DyingDead = 97,
		/// <summary>
		/// Represents the Task "CTaskWanderingScenario".
		/// </summary>
		WanderingScenario = 100,
		/// <summary>
		/// Represents the Task "CTaskWanderingInRadiusScenario".
		/// </summary>
		WanderingInRadiusScenario = 101,
		/// <summary>
		/// Represents the Task "CTaskMoveBetweenPointsScenario".
		/// </summary>
		MoveBetweenPointsScenario = 103,
		/// <summary>
		/// Represents the Task "CTaskChatScenario".
		/// </summary>
		ChatScenario = 104,
		/// <summary>
		/// Represents the Task "CTaskCowerScenario".
		/// </summary>
		CowerScenario = 106,
		/// <summary>
		/// Represents the Task "CTaskDeadBodyScenario".
		/// </summary>
		DeadBodyScenario = 107,
		/// <summary>
		/// Represents the Task "CTaskSayAudio".
		/// </summary>
		SayAudio = 114,
		/// <summary>
		/// Represents the Task "CTaskWaitForSteppingOut".
		/// </summary>
		WaitForSteppingOut = 116,
		/// <summary>
		/// Represents the Task "CTaskCoupleScenario".
		/// </summary>
		CoupleScenario = 117,
		/// <summary>
		/// Represents the Task "CTaskUseScenario".
		/// </summary>
		UseScenario = 118,
		/// <summary>
		/// Represents the Task "CTaskUseVehicleScenario".
		/// </summary>
		UseVehicleScenario = 119,
		/// <summary>
		/// Represents the Task "CTaskUnalerted".
		/// </summary>
		Unalerted = 120,
		/// <summary>
		/// Represents the Task "CTaskStealVehicle".
		/// </summary>
		StealVehicle = 121,
		/// <summary>
		/// Represents the Task "CTaskReactToPursuit".
		/// </summary>
		ReactToPursuit = 122,
		/// <summary>
		/// Represents the Task "CTaskHitWall".
		/// </summary>
		HitWall = 125,
		/// <summary>
		/// Represents the Task "CTaskCower".
		/// </summary>
		Cower = 126,
		/// <summary>
		/// Represents the Task "CTaskCrouch".
		/// </summary>
		Crouch = 127,
		/// <summary>
		/// Represents the Task "CTaskMelee".
		/// </summary>
		Melee = 128,
		/// <summary>
		/// Represents the Task "CTaskMoveMeleeMovement".
		/// </summary>
		MoveMeleeMovement = 129,
		/// <summary>
		/// Represents the Task "CTaskMeleeActionResult".
		/// </summary>
		MeleeActionResult = 130,
		/// <summary>
		/// Represents the Task "CTaskMeleeUpperbodyAnims".
		/// </summary>
		MeleeUpperbodyAnims = 131,
		/// <summary>
		/// Represents the Task "CTaskMoVEScripted".
		/// </summary>
		MoVEScripted = 133,
		/// <summary>
		/// Represents the Task "CTaskScriptedAnimation".
		/// </summary>
		ScriptedAnimation = 134,
		/// <summary>
		/// Represents the Task "CTaskSynchronizedScene".
		/// </summary>
		SynchronizedScene = 135,
		/// <summary>
		/// Represents the Task "CTaskComplexEvasiveStep".
		/// </summary>
		ComplexEvasiveStep = 137,
		/// <summary>
		/// Represents the Task "CTaskWalkRoundCarWhileWandering".
		/// </summary>
		WalkRoundCarWhileWandering = 138,
		/// <summary>
		/// Represents the Task "CTaskComplexStuckInAir".
		/// </summary>
		ComplexStuckInAir = 140,
		/// <summary>
		/// Represents the Task "CTaskWalkRoundEntity".
		/// </summary>
		WalkRoundEntity = 141,
		/// <summary>
		/// Represents the Task "CTaskMoveWalkRoundVehicle".
		/// </summary>
		MoveWalkRoundVehicle = 142,
		/// <summary>
		/// Represents the Task "CTaskReactToGunAimedAt".
		/// </summary>
		ReactToGunAimedAt = 144,
		/// <summary>
		/// Represents the Task "CTaskDuckAndCover".
		/// </summary>
		DuckAndCover = 146,
		/// <summary>
		/// Represents the Task "CTaskAggressiveRubberneck".
		/// </summary>
		AggressiveRubberneck = 147,
		/// <summary>
		/// Represents the Task "CTaskInVehicleBasic".
		/// </summary>
		InVehicleBasic = 150,
		/// <summary>
		/// Represents the Task "CTaskCarDriveWander".
		/// </summary>
		CarDriveWander = 151,
		/// <summary>
		/// Represents the Task "CTaskLeaveAnyCar".
		/// </summary>
		LeaveAnyCar = 152,
		/// <summary>
		/// Represents the Task "CTaskComplexGetOffBoat".
		/// </summary>
		ComplexGetOffBoat = 153,
		/// <summary>
		/// Represents the Task "CTaskCarSetTempAction".
		/// </summary>
		CarSetTempAction = 155,
		/// <summary>
		/// Represents the Task "CTaskBringVehicleToHalt".
		/// </summary>
		BringVehicleToHalt = 156,
		/// <summary>
		/// Represents the Task "CTaskCarDrive".
		/// </summary>
		CarDrive = 157,
		/// <summary>
		/// Represents the Task "CTaskPlayerDrive".
		/// </summary>
		PlayerDrive = 159,
		/// <summary>
		/// Represents the Task "CTaskEnterVehicle".
		/// </summary>
		EnterVehicle = 160,
		/// <summary>
		/// Represents the Task "CTaskEnterVehicleAlign".
		/// </summary>
		EnterVehicleAlign = 161,
		/// <summary>
		/// Represents the Task "CTaskOpenVehicleDoorFromOutside".
		/// </summary>
		OpenVehicleDoorFromOutside = 162,
		/// <summary>
		/// Represents the Task "CTaskEnterVehicleSeat".
		/// </summary>
		EnterVehicleSeat = 163,
		/// <summary>
		/// Represents the Task "CTaskCloseVehicleDoorFromInside".
		/// </summary>
		CloseVehicleDoorFromInside = 164,
		/// <summary>
		/// Represents the Task "CTaskInVehicleSeatShuffle".
		/// </summary>
		InVehicleSeatShuffle = 165,
		/// <summary>
		/// Represents the Task "CTaskExitVehicleSeat".
		/// </summary>
		ExitVehicleSeat = 167,
		/// <summary>
		/// Represents the Task "CTaskCloseVehicleDoorFromOutside".
		/// </summary>
		CloseVehicleDoorFromOutside = 168,
		/// <summary>
		/// Represents the Task "CTaskControlVehicle".
		/// </summary>
		ControlVehicle = 169,
		/// <summary>
		/// Represents the Task "CTaskMotionInAutomobile".
		/// </summary>
		MotionInAutomobile = 170,
		/// <summary>
		/// Represents the Task "CTaskMotionOnBicycle".
		/// </summary>
		MotionOnBicycle = 171,
		/// <summary>
		/// Represents the Task "CTaskMotionOnBicycleController".
		/// </summary>
		MotionOnBicycleController = 172,
		/// <summary>
		/// Represents the Task "CTaskMotionInVehicle".
		/// </summary>
		MotionInVehicle = 173,
		/// <summary>
		/// Represents the Task "CTaskMotionInTurret".
		/// </summary>
		MotionInTurret = 174,
		/// <summary>
		/// Represents the Task "CTaskReactToBeingJacked".
		/// </summary>
		ReactToBeingJacked = 175,
		/// <summary>
		/// Represents the Task "CTaskReactToBeingAskedToLeaveVehicle".
		/// </summary>
		ReactToBeingAskedToLeaveVehicle = 176,
		/// <summary>
		/// Represents the Task "CTaskTryToGrabVehicleDoor".
		/// </summary>
		TryToGrabVehicleDoor = 177,
		/// <summary>
		/// Represents the Task "CTaskGetOnTrain".
		/// </summary>
		GetOnTrain = 178,
		/// <summary>
		/// Represents the Task "CTaskGetOffTrain".
		/// </summary>
		GetOffTrain = 179,
		/// <summary>
		/// Represents the Task "CTaskRideTrain".
		/// </summary>
		RideTrain = 180,
		/// <summary>
		/// Represents the Task "CTaskMountThrowProjectile".
		/// </summary>
		MountThrowProjectile = 190,
		/// <summary>
		/// Represents the Task "CTaskGoToCarDoorAndStandStill".
		/// </summary>
		GoToCarDoorAndStandStill = 195,
		/// <summary>
		/// Represents the Task "CTaskMoveGoToVehicleDoor".
		/// </summary>
		MoveGoToVehicleDoor = 196,
		/// <summary>
		/// Represents the Task "CTaskSetPedInVehicle".
		/// </summary>
		SetPedInVehicle = 197,
		/// <summary>
		/// Represents the Task "CTaskSetPedOutOfVehicle".
		/// </summary>
		SetPedOutOfVehicle = 198,
		/// <summary>
		/// Represents the Task "CTaskVehicleMountedWeapon".
		/// </summary>
		VehicleMountedWeapon = 199,
		/// <summary>
		/// Represents the Task "CTaskVehicleGun".
		/// </summary>
		VehicleGun = 200,
		/// <summary>
		/// Represents the Task "CTaskVehicleProjectile".
		/// </summary>
		VehicleProjectile = 201,
		/// <summary>
		/// Represents the Task "CTaskSmashCarWindow".
		/// </summary>
		SmashCarWindow = 204,
		/// <summary>
		/// Represents the Task "CTaskMoveGoToPoint".
		/// </summary>
		MoveGoToPoint = 205,
		/// <summary>
		/// Represents the Task "CTaskMoveAchieveHeading".
		/// </summary>
		MoveAchieveHeading = 206,
		/// <summary>
		/// Represents the Task "CTaskMoveFaceTarget".
		/// </summary>
		MoveFaceTarget = 207,
		/// <summary>
		/// Represents the Task "CTaskComplexGoToPointAndStandStillTimed".
		/// </summary>
		ComplexGoToPointAndStandStillTimed = 208,
		/// <summary>
		/// Represents the Task "CTaskMoveGoToPointAndStandStill".
		/// </summary>
		MoveGoToPointAndStandStill = 208,
		/// <summary>
		/// Represents the Task "CTaskMoveFollowPointRoute".
		/// </summary>
		MoveFollowPointRoute = 209,
		/// <summary>
		/// Represents the Task "CTaskMoveSeekEntity_CEntitySeekPosCalculatorStandard".
		/// </summary>
		MoveSeekEntity_CEntitySeekPosCalculatorStandard = 210,
		/// <summary>
		/// Represents the Task "CTaskMoveSeekEntity_CEntitySeekPosCalculatorLastNavMeshIntersection".
		/// </summary>
		MoveSeekEntity_CEntitySeekPosCalculatorLastNavMeshIntersection = 211,
		/// <summary>
		/// Represents the Task "CTaskMoveSeekEntity_CEntitySeekPosCalculatorLastNavMeshIntersection2".
		/// </summary>
		MoveSeekEntity_CEntitySeekPosCalculatorLastNavMeshIntersection2 = 212,
		/// <summary>
		/// Represents the Task "CTaskMoveSeekEntity_CEntitySeekPosCalculatorXYOffsetFixed".
		/// </summary>
		MoveSeekEntity_CEntitySeekPosCalculatorXYOffsetFixed = 213,
		/// <summary>
		/// Represents the Task "CTaskMoveSeekEntity_CEntitySeekPosCalculatorXYOffsetFixed2".
		/// </summary>
		MoveSeekEntity_CEntitySeekPosCalculatorXYOffsetFixed2 = 214,
		/// <summary>
		/// Represents the Task "CTaskExhaustedFlee".
		/// </summary>
		ExhaustedFlee = 215,
		/// <summary>
		/// Represents the Task "CTaskGrowlAndFlee".
		/// </summary>
		GrowlAndFlee = 216,
		/// <summary>
		/// Represents the Task "CTaskScenarioFlee".
		/// </summary>
		ScenarioFlee = 217,
		/// <summary>
		/// Represents the Task "CTaskSmartFlee".
		/// </summary>
		SmartFlee = 218,
		/// <summary>
		/// Represents the Task "CTaskFlyAway".
		/// </summary>
		FlyAway = 219,
		/// <summary>
		/// Represents the Task "CTaskWalkAway".
		/// </summary>
		WalkAway = 220,
		/// <summary>
		/// Represents the Task "CTaskWander".
		/// </summary>
		Wander = 221,
		/// <summary>
		/// Represents the Task "CTaskWanderInArea".
		/// </summary>
		WanderInArea = 222,
		/// <summary>
		/// Represents the Task "CTaskFollowLeaderInFormation".
		/// </summary>
		FollowLeaderInFormation = 223,
		/// <summary>
		/// Represents the Task "CTaskGoToPointAnyMeans".
		/// </summary>
		GoToPointAnyMeans = 224,
		/// <summary>
		/// Represents the Task "CTaskTurnToFaceEntityOrCoord".
		/// </summary>
		TurnToFaceEntityOrCoord = 225,
		/// <summary>
		/// Represents the Task "CTaskFollowLeaderAnyMeans".
		/// </summary>
		FollowLeaderAnyMeans = 226,
		/// <summary>
		/// Represents the Task "CTaskFlyToPoint".
		/// </summary>
		FlyToPoint = 228,
		/// <summary>
		/// Represents the Task "CTaskFlyingWander".
		/// </summary>
		FlyingWander = 229,
		/// <summary>
		/// Represents the Task "CTaskGoToPointAiming".
		/// </summary>
		GoToPointAiming = 230,
		/// <summary>
		/// Represents the Task "CTaskGoToScenario".
		/// </summary>
		GoToScenario = 231,
		/// <summary>
		/// Represents the Task "CTaskSeekEntityAiming".
		/// </summary>
		SeekEntityAiming = 233,
		/// <summary>
		/// Represents the Task "CTaskSlideToCoord".
		/// </summary>
		SlideToCoord = 234,
		/// <summary>
		/// Represents the Task "CTaskSwimmingWander".
		/// </summary>
		SwimmingWander = 235,
		/// <summary>
		/// Represents the Task "CTaskMoveTrackingEntity".
		/// </summary>
		MoveTrackingEntity = 237,
		/// <summary>
		/// Represents the Task "CTaskMoveFollowNavMesh".
		/// </summary>
		MoveFollowNavMesh = 238,
		/// <summary>
		/// Represents the Task "CTaskMoveGoToPointOnRoute".
		/// </summary>
		MoveGoToPointOnRoute = 239,
		/// <summary>
		/// Represents the Task "CTaskEscapeBlast".
		/// </summary>
		EscapeBlast = 240,
		/// <summary>
		/// Represents the Task "CTaskMoveWander".
		/// </summary>
		MoveWander = 241,
		/// <summary>
		/// Represents the Task "CTaskMoveBeInFormation".
		/// </summary>
		MoveBeInFormation = 242,
		/// <summary>
		/// Represents the Task "CTaskMoveCrowdAroundLocation".
		/// </summary>
		MoveCrowdAroundLocation = 243,
		/// <summary>
		/// Represents the Task "CTaskMoveCrossRoadAtTrafficLights".
		/// </summary>
		MoveCrossRoadAtTrafficLights = 244,
		/// <summary>
		/// Represents the Task "CTaskMoveWaitForTraffic".
		/// </summary>
		MoveWaitForTraffic = 245,
		/// <summary>
		/// Represents the Task "CTaskMoveGoToPointStandStillAchieveHeading".
		/// </summary>
		MoveGoToPointStandStillAchieveHeading = 246,
		/// <summary>
		/// Represents the Task "CTaskMoveGetOntoMainNavMesh".
		/// </summary>
		MoveGetOntoMainNavMesh = 251,
		/// <summary>
		/// Represents the Task "CTaskMoveSlideToCoord".
		/// </summary>
		MoveSlideToCoord = 252,
		/// <summary>
		/// Represents the Task "CTaskMoveGoToPointRelativeToEntityAndStandStill".
		/// </summary>
		MoveGoToPointRelativeToEntityAndStandStill = 253,
		/// <summary>
		/// Represents the Task "CTaskHelicopterStrafe".
		/// </summary>
		HelicopterStrafe = 254,
		/// <summary>
		/// Represents the Task "CTaskGetOutOfWater".
		/// </summary>
		GetOutOfWater = 256,
		/// <summary>
		/// Represents the Task "CTaskMoveFollowEntityOffset".
		/// </summary>
		MoveFollowEntityOffset = 259,
		/// <summary>
		/// Represents the Task "CTaskFollowWaypointRecording".
		/// </summary>
		FollowWaypointRecording = 261,
		/// <summary>
		/// Represents the Task "CTaskMotionPed".
		/// </summary>
		MotionPed = 264,
		/// <summary>
		/// Represents the Task "CTaskMotionPedLowLod".
		/// </summary>
		MotionPedLowLod = 265,
		/// <summary>
		/// Represents the Task "CTaskHumanLocomotion".
		/// </summary>
		HumanLocomotion = 268,
		/// <summary>
		/// Represents the Task "CTaskMotionBasicLocomotionLowLod".
		/// </summary>
		MotionBasicLocomotionLowLod = 269,
		/// <summary>
		/// Represents the Task "CTaskMotionStrafing".
		/// </summary>
		MotionStrafing = 270,
		/// <summary>
		/// Represents the Task "CTaskMotionTennis".
		/// </summary>
		MotionTennis = 271,
		/// <summary>
		/// Represents the Task "CTaskMotionAiming".
		/// </summary>
		MotionAiming = 272,
		/// <summary>
		/// Represents the Task "CTaskBirdLocomotion".
		/// </summary>
		BirdLocomotion = 273,
		/// <summary>
		/// Represents the Task "CTaskFlightlessBirdLocomotion".
		/// </summary>
		FlightlessBirdLocomotion = 274,
		/// <summary>
		/// Represents the Task "CTaskFishLocomotion".
		/// </summary>
		FishLocomotion = 278,
		/// <summary>
		/// Represents the Task "CTaskQuadLocomotion".
		/// </summary>
		QuadLocomotion = 279,
		/// <summary>
		/// Represents the Task "CTaskMotionDiving".
		/// </summary>
		MotionDiving = 280,
		/// <summary>
		/// Represents the Task "CTaskMotionSwimming".
		/// </summary>
		MotionSwimming = 281,
		/// <summary>
		/// Represents the Task "CTaskMotionParachuting".
		/// </summary>
		MotionParachuting = 282,
		/// <summary>
		/// Represents the Task "CTaskMotionDrunk".
		/// </summary>
		MotionDrunk = 283,
		/// <summary>
		/// Represents the Task "CTaskRepositionMove".
		/// </summary>
		RepositionMove = 284,
		/// <summary>
		/// Represents the Task "CTaskMotionAimingTransition".
		/// </summary>
		MotionAimingTransition = 285,
		/// <summary>
		/// Represents the Task "CTaskThrowProjectile".
		/// </summary>
		ThrowProjectile = 286,
		/// <summary>
		/// Represents the Task "CTaskCover".
		/// </summary>
		Cover = 287,
		/// <summary>
		/// Represents the Task "CTaskMotionInCover".
		/// </summary>
		MotionInCover = 288,
		/// <summary>
		/// Represents the Task "CTaskAimAndThrowProjectile".
		/// </summary>
		AimAndThrowProjectile = 289,
		/// <summary>
		/// Represents the Task "CTaskGun".
		/// </summary>
		Gun = 290,
		/// <summary>
		/// Represents the Task "CTaskAimFromGround".
		/// </summary>
		AimFromGround = 291,
		/// <summary>
		/// Represents the Task "CTaskAimGunVehicleDriveBy".
		/// </summary>
		AimGunVehicleDriveBy = 295,
		/// <summary>
		/// Represents the Task "CTaskAimGunScripted".
		/// </summary>
		AimGunScripted = 296,
		/// <summary>
		/// Represents the Task "CTaskReloadGun".
		/// </summary>
		ReloadGun = 298,
		/// <summary>
		/// Represents the Task "CTaskWeaponBlocked".
		/// </summary>
		WeaponBlocked = 299,
		/// <summary>
		/// Represents the Task "CTaskEnterCover".
		/// </summary>
		EnterCover = 300,
		/// <summary>
		/// Represents the Task "CTaskExitCover".
		/// </summary>
		ExitCover = 301,
		/// <summary>
		/// Represents the Task "CTaskAimGunFromCoverIntro".
		/// </summary>
		AimGunFromCoverIntro = 302,
		/// <summary>
		/// Represents the Task "CTaskAimGunFromCoverOutro".
		/// </summary>
		AimGunFromCoverOutro = 303,
		/// <summary>
		/// Represents the Task "CTaskAimGunBlindFire".
		/// </summary>
		AimGunBlindFire = 304,
		/// <summary>
		/// Represents the Task "CTaskCombatClosestTargetInArea".
		/// </summary>
		CombatClosestTargetInArea = 307,
		/// <summary>
		/// Represents the Task "CTaskCombatAdditionalTask".
		/// </summary>
		CombatAdditionalTask = 308,
		/// <summary>
		/// Represents the Task "CTaskInCover".
		/// </summary>
		InCover = 309,
		/// <summary>
		/// Represents the Task "CTaskAimSweep".
		/// </summary>
		AimSweep = 313,
		/// <summary>
		/// Represents the Task "CTaskSharkCircle".
		/// </summary>
		SharkCircle = 319,
		/// <summary>
		/// Represents the Task "CTaskSharkAttack".
		/// </summary>
		SharkAttack = 320,
		/// <summary>
		/// Represents the Task "CTaskAgitated".
		/// </summary>
		Agitated = 321,
		/// <summary>
		/// Represents the Task "CTaskAgitatedAction".
		/// </summary>
		AgitatedAction = 322,
		/// <summary>
		/// Represents the Task "CTaskConfront".
		/// </summary>
		Confront = 323,
		/// <summary>
		/// Represents the Task "CTaskIntimidate".
		/// </summary>
		Intimidate = 324,
		/// <summary>
		/// Represents the Task "CTaskShove".
		/// </summary>
		Shove = 325,
		/// <summary>
		/// Represents the Task "CTaskShoved".
		/// </summary>
		Shoved = 326,
		/// <summary>
		/// Represents the Task "CTaskCrouchToggle".
		/// </summary>
		CrouchToggle = 328,
		/// <summary>
		/// Represents the Task "CTaskRevive".
		/// </summary>
		Revive = 329,
		/// <summary>
		/// Represents the Task "CTaskParachute".
		/// </summary>
		Parachute = 335,
		/// <summary>
		/// Represents the Task "CTaskParachuteObject".
		/// </summary>
		ParachuteObject = 336,
		/// <summary>
		/// Represents the Task "CTaskTakeOffPedVariation".
		/// </summary>
		TakeOffPedVariation = 337,
		/// <summary>
		/// Represents the Task "CTaskCombatSeekCover".
		/// </summary>
		CombatSeekCover = 340,
		/// <summary>
		/// Represents the Task "CTaskCombatFlank".
		/// </summary>
		CombatFlank = 342,
		/// <summary>
		/// Represents the Task "CTaskCombat".
		/// </summary>
		Combat = 343,
		/// <summary>
		/// Represents the Task "CTaskCombatMounted".
		/// </summary>
		CombatMounted = 344,
		/// <summary>
		/// Represents the Task "CTaskMoveCircle".
		/// </summary>
		MoveCircle = 345,
		/// <summary>
		/// Represents the Task "CTaskMoveCombatMounted".
		/// </summary>
		MoveCombatMounted = 346,
		/// <summary>
		/// Represents the Task "CTaskSearch".
		/// </summary>
		Search = 347,
		/// <summary>
		/// Represents the Task "CTaskSearchOnFoot".
		/// </summary>
		SearchOnFoot = 348,
		/// <summary>
		/// Represents the Task "CTaskSearchInAutomobile".
		/// </summary>
		SearchInAutomobile = 349,
		/// <summary>
		/// Represents the Task "CTaskSearchInBoat".
		/// </summary>
		SearchInBoat = 350,
		/// <summary>
		/// Represents the Task "CTaskSearchInHeli".
		/// </summary>
		SearchInHeli = 351,
		/// <summary>
		/// Represents the Task "CTaskThreatResponse".
		/// </summary>
		ThreatResponse = 352,
		/// <summary>
		/// Represents the Task "CTaskInvestigate".
		/// </summary>
		Investigate = 353,
		/// <summary>
		/// Represents the Task "CTaskStandGuardFSM".
		/// </summary>
		StandGuardFSM = 354,
		/// <summary>
		/// Represents the Task "CTaskPatrol".
		/// </summary>
		Patrol = 355,
		/// <summary>
		/// Represents the Task "CTaskShootAtTarget".
		/// </summary>
		ShootAtTarget = 356,
		/// <summary>
		/// Represents the Task "CTaskSetAndGuardArea".
		/// </summary>
		SetAndGuardArea = 357,
		/// <summary>
		/// Represents the Task "CTaskStandGuard".
		/// </summary>
		StandGuard = 358,
		/// <summary>
		/// Represents the Task "CTaskSeparate".
		/// </summary>
		Separate = 359,
		/// <summary>
		/// Represents the Task "CTaskStayInCover".
		/// </summary>
		StayInCover = 360,
		/// <summary>
		/// Represents the Task "CTaskVehicleCombat".
		/// </summary>
		VehicleCombat = 361,
		/// <summary>
		/// Represents the Task "CTaskVehiclePersuit".
		/// </summary>
		VehiclePersuit = 362,
		/// <summary>
		/// Represents the Task "CTaskVehicleChase".
		/// </summary>
		VehicleChase = 363,
		/// <summary>
		/// Represents the Task "CTaskDraggingToSafety".
		/// </summary>
		DraggingToSafety = 364,
		/// <summary>
		/// Represents the Task "CTaskDraggedToSafety".
		/// </summary>
		DraggedToSafety = 365,
		/// <summary>
		/// Represents the Task "CTaskVariedAimPose".
		/// </summary>
		VariedAimPose = 366,
		/// <summary>
		/// Represents the Task "CTaskMoveWithinAttackWindow".
		/// </summary>
		MoveWithinAttackWindow = 367,
		/// <summary>
		/// Represents the Task "CTaskMoveWithinDefensiveArea".
		/// </summary>
		MoveWithinDefensiveArea = 368,
		/// <summary>
		/// Represents the Task "CTaskShootOutTire".
		/// </summary>
		ShootOutTire = 369,
		/// <summary>
		/// Represents the Task "CTaskShellShocked".
		/// </summary>
		ShellShocked = 370,
		/// <summary>
		/// Represents the Task "CTaskBoatChase".
		/// </summary>
		BoatChase = 371,
		/// <summary>
		/// Represents the Task "CTaskBoatCombat".
		/// </summary>
		BoatCombat = 372,
		/// <summary>
		/// Represents the Task "CTaskBoatStrafe".
		/// </summary>
		BoatStrafe = 373,
		/// <summary>
		/// Represents the Task "CTaskHeliChase".
		/// </summary>
		HeliChase = 374,
		/// <summary>
		/// Represents the Task "CTaskHeliCombat".
		/// </summary>
		HeliCombat = 375,
		/// <summary>
		/// Represents the Task "CTaskSubmarineCombat".
		/// </summary>
		SubmarineCombat = 376,
		/// <summary>
		/// Represents the Task "CTaskSubmarineChase".
		/// </summary>
		SubmarineChase = 377,
		/// <summary>
		/// Represents the Task "CTaskPlaneChase".
		/// </summary>
		PlaneChase = 378,
		/// <summary>
		/// Represents the Task "CTaskTargetUnreachable".
		/// </summary>
		TargetUnreachable = 379,
		/// <summary>
		/// Represents the Task "CTaskTargetUnreachableInInterior".
		/// </summary>
		TargetUnreachableInInterior = 380,
		/// <summary>
		/// Represents the Task "CTaskTargetUnreachableInExterior".
		/// </summary>
		TargetUnreachableInExterior = 381,
		/// <summary>
		/// Represents the Task "CTaskStealthKill".
		/// </summary>
		StealthKill = 382,
		/// <summary>
		/// Represents the Task "CTaskWrithe".
		/// </summary>
		Writhe = 383,
		/// <summary>
		/// Represents the Task "CTaskAdvance".
		/// </summary>
		Advance = 384,
		/// <summary>
		/// Represents the Task "CTaskCharge".
		/// </summary>
		Charge = 385,
		/// <summary>
		/// Represents the Task "CTaskMoveToTacticalPoint".
		/// </summary>
		MoveToTacticalPoint = 386,
		/// <summary>
		/// Represents the Task "CTaskToHurtTransit".
		/// </summary>
		ToHurtTransit = 387,
		/// <summary>
		/// Represents the Task "CTaskAnimatedHitByExplosion".
		/// </summary>
		AnimatedHitByExplosion = 388,
		/// <summary>
		/// Represents the Task "CTaskNMRelax".
		/// </summary>
		NMRelax = 389,
		/// <summary>
		/// Represents the Task "CTaskNMPose".
		/// </summary>
		NMPose = 391,
		/// <summary>
		/// Represents the Task "CTaskNMBrace".
		/// </summary>
		NMBrace = 392,
		/// <summary>
		/// Represents the Task "CTaskNMBuoyancy".
		/// </summary>
		NMBuoyancy = 393,
		/// <summary>
		/// Represents the Task "CTaskNMInjuredOnGround".
		/// </summary>
		NMInjuredOnGround = 394,
		/// <summary>
		/// Represents the Task "CTaskNMShot".
		/// </summary>
		NMShot = 395,
		/// <summary>
		/// Represents the Task "CTaskNMHighFall".
		/// </summary>
		NMHighFall = 396,
		/// <summary>
		/// Represents the Task "CTaskNMBalance".
		/// </summary>
		NMBalance = 397,
		/// <summary>
		/// Represents the Task "CTaskNMElectrocute".
		/// </summary>
		NMElectrocute = 398,
		/// <summary>
		/// Represents the Task "CTaskNMPrototype".
		/// </summary>
		NMPrototype = 399,
		/// <summary>
		/// Represents the Task "CTaskNMExplosion".
		/// </summary>
		NMExplosion = 400,
		/// <summary>
		/// Represents the Task "CTaskNMOnFire".
		/// </summary>
		NMOnFire = 401,
		/// <summary>
		/// Represents the Task "CTaskNMScriptControl".
		/// </summary>
		NMScriptControl = 402,
		/// <summary>
		/// Represents the Task "CTaskNMJumpRollFromRoadVehicle".
		/// </summary>
		NMJumpRollFromRoadVehicle = 403,
		/// <summary>
		/// Represents the Task "CTaskNMFlinch".
		/// </summary>
		NMFlinch = 404,
		/// <summary>
		/// Represents the Task "CTaskNMSit".
		/// </summary>
		NMSit = 405,
		/// <summary>
		/// Represents the Task "CTaskNMFallDown".
		/// </summary>
		NMFallDown = 406,
		/// <summary>
		/// Represents the Task "CTaskBlendFromNM".
		/// </summary>
		BlendFromNM = 407,
		/// <summary>
		/// Represents the Task "CTaskNMControl".
		/// </summary>
		NMControl = 408,
		/// <summary>
		/// Represents the Task "CTaskNMDangle".
		/// </summary>
		NMDangle = 409,
		/// <summary>
		/// Represents the Task "CTaskNMGenericAttach".
		/// </summary>
		NMGenericAttach = 412,
		/// <summary>
		/// Represents the Task "CTaskNMDraggingToSafety".
		/// </summary>
		NMDraggingToSafety = 414,
		/// <summary>
		/// Represents the Task "CTaskNMThroughWindscreen".
		/// </summary>
		NMThroughWindscreen = 415,
		/// <summary>
		/// Represents the Task "CTaskNMRiverRapids".
		/// </summary>
		NMRiverRapids = 416,
		/// <summary>
		/// Represents the Task "CTaskNMSimple".
		/// </summary>
		NMSimple = 417,
		/// <summary>
		/// Represents the Task "CTaskRageRagdoll".
		/// </summary>
		RageRagdoll = 418,
		/// <summary>
		/// Represents the Task "CTaskJumpVault".
		/// </summary>
		JumpVault = 421,
		/// <summary>
		/// Represents the Task "CTaskJump".
		/// </summary>
		Jump = 422,
		/// <summary>
		/// Represents the Task "CTaskFall".
		/// </summary>
		Fall = 423,
		/// <summary>
		/// Represents the Task "CTaskReactAimWeapon".
		/// </summary>
		ReactAimWeapon = 425,
		/// <summary>
		/// Represents the Task "CTaskChat".
		/// </summary>
		Chat = 426,
		/// <summary>
		/// Represents the Task "CTaskMobilePhone".
		/// </summary>
		MobilePhone = 427,
		/// <summary>
		/// Represents the Task "CTaskReactToDeadPed".
		/// </summary>
		ReactToDeadPed = 428,
		/// <summary>
		/// Represents the Task "CTaskSearchForUnknownThreat".
		/// </summary>
		SearchForUnknownThreat = 430,
		/// <summary>
		/// Represents the Task "CTaskBomb".
		/// </summary>
		Bomb = 432,
		/// <summary>
		/// Represents the Task "CTaskDetonator".
		/// </summary>
		Detonator = 433,
		/// <summary>
		/// Represents the Task "CTaskAnimatedAttach".
		/// </summary>
		AnimatedAttach = 435,
		/// <summary>
		/// Represents the Task "CTaskCutScene".
		/// </summary>
		CutScene = 441,
		/// <summary>
		/// Represents the Task "CTaskReactToExplosion".
		/// </summary>
		ReactToExplosion = 442,
		/// <summary>
		/// Represents the Task "CTaskReactToImminentExplosion".
		/// </summary>
		ReactToImminentExplosion = 443,
		/// <summary>
		/// Represents the Task "CTaskDiveToGround".
		/// </summary>
		DiveToGround = 444,
		/// <summary>
		/// Represents the Task "CTaskReactAndFlee".
		/// </summary>
		ReactAndFlee = 445,
		/// <summary>
		/// Represents the Task "CTaskSidestep".
		/// </summary>
		Sidestep = 446,
		/// <summary>
		/// Represents the Task "CTaskCallPolice".
		/// </summary>
		CallPolice = 447,
		/// <summary>
		/// Represents the Task "CTaskReactInDirection".
		/// </summary>
		ReactInDirection = 448,
		/// <summary>
		/// Represents the Task "CTaskReactToBuddyShot".
		/// </summary>
		ReactToBuddyShot = 449,
		/// <summary>
		/// Represents the Task "CTaskVehicleGoToAutomobileNew".
		/// </summary>
		VehicleGoToAutomobileNew = 454,
		/// <summary>
		/// Represents the Task "CTaskVehicleGoToPlane".
		/// </summary>
		VehicleGoToPlane = 455,
		/// <summary>
		/// Represents the Task "CTaskVehicleGoToHelicopter".
		/// </summary>
		VehicleGoToHelicopter = 456,
		/// <summary>
		/// Represents the Task "CTaskVehicleGoToSubmarine".
		/// </summary>
		VehicleGoToSubmarine = 457,
		/// <summary>
		/// Represents the Task "CTaskVehicleGoToBoat".
		/// </summary>
		VehicleGoToBoat = 458,
		/// <summary>
		/// Represents the Task "CTaskVehicleGoToPointAutomobile".
		/// </summary>
		VehicleGoToPointAutomobile = 459,
		/// <summary>
		/// Represents the Task "CTaskVehicleGoToPointWithAvoidanceAutomobile".
		/// </summary>
		VehicleGoToPointWithAvoidanceAutomobile = 460,
		/// <summary>
		/// Represents the Task "CTaskVehiclePursue".
		/// </summary>
		VehiclePursue = 461,
		/// <summary>
		/// Represents the Task "CTaskVehicleRam".
		/// </summary>
		VehicleRam = 462,
		/// <summary>
		/// Represents the Task "CTaskVehicleSpinOut".
		/// </summary>
		VehicleSpinOut = 463,
		/// <summary>
		/// Represents the Task "CTaskVehicleApproach".
		/// </summary>
		VehicleApproach = 464,
		/// <summary>
		/// Represents the Task "CTaskVehicleThreePointTurn".
		/// </summary>
		VehicleThreePointTurn = 465,
		/// <summary>
		/// Represents the Task "CTaskVehicleDeadDriver".
		/// </summary>
		VehicleDeadDriver = 466,
		/// <summary>
		/// Represents the Task "CTaskVehicleCruiseNew".
		/// </summary>
		VehicleCruiseNew = 467,
		/// <summary>
		/// Represents the Task "CTaskVehicleCruiseBoat".
		/// </summary>
		VehicleCruiseBoat = 468,
		/// <summary>
		/// Represents the Task "CTaskVehicleStop".
		/// </summary>
		VehicleStop = 469,
		/// <summary>
		/// Represents the Task "CTaskVehiclePullOver".
		/// </summary>
		VehiclePullOver = 470,
		/// <summary>
		/// Represents the Task "CTaskVehiclePassengerExit".
		/// </summary>
		VehiclePassengerExit = 471,
		/// <summary>
		/// Represents the Task "CTaskVehicleFlee".
		/// </summary>
		VehicleFlee = 472,
		/// <summary>
		/// Represents the Task "CTaskVehicleFleeAirborne".
		/// </summary>
		VehicleFleeAirborne = 473,
		/// <summary>
		/// Represents the Task "CTaskVehicleFleeBoat".
		/// </summary>
		VehicleFleeBoat = 474,
		/// <summary>
		/// Represents the Task "CTaskVehicleFollowRecording".
		/// </summary>
		VehicleFollowRecording = 475,
		/// <summary>
		/// Represents the Task "CTaskVehicleFollow".
		/// </summary>
		VehicleFollow = 476,
		/// <summary>
		/// Represents the Task "CTaskVehicleBlock".
		/// </summary>
		VehicleBlock = 477,
		/// <summary>
		/// Represents the Task "CTaskVehicleBlockCruiseInFront".
		/// </summary>
		VehicleBlockCruiseInFront = 478,
		/// <summary>
		/// Represents the Task "CTaskVehicleBlockBrakeInFront".
		/// </summary>
		VehicleBlockBrakeInFront = 479,
		/// <summary>
		/// Represents the Task "CTaskVehicleBlockBackAndForth".
		/// </summary>
		VehicleBlockBackAndForth = 478,
		/// <summary>
		/// Represents the Task "CTaskVehicleCrash".
		/// </summary>
		VehicleCrash = 481,
		/// <summary>
		/// Represents the Task "CTaskVehicleLand".
		/// </summary>
		VehicleLand = 482,
		/// <summary>
		/// Represents the Task "CTaskVehicleLandPlane".
		/// </summary>
		VehicleLandPlane = 483,
		/// <summary>
		/// Represents the Task "CTaskVehicleHover".
		/// </summary>
		VehicleHover = 484,
		/// <summary>
		/// Represents the Task "CTaskVehicleAttack".
		/// </summary>
		VehicleAttack = 485,
		/// <summary>
		/// Represents the Task "CTaskVehicleAttackTank".
		/// </summary>
		VehicleAttackTank = 486,
		/// <summary>
		/// Represents the Task "CTaskVehicleCircle".
		/// </summary>
		VehicleCircle = 487,
		/// <summary>
		/// Represents the Task "CTaskVehiclePoliceBehaviour".
		/// </summary>
		VehiclePoliceBehaviour = 488,
		/// <summary>
		/// Represents the Task "CTaskVehiclePoliceBehaviourHelicopter".
		/// </summary>
		VehiclePoliceBehaviourHelicopter = 489,
		/// <summary>
		/// Represents the Task "CTaskVehiclePoliceBehaviourBoat".
		/// </summary>
		VehiclePoliceBehaviourBoat = 490,
		/// <summary>
		/// Represents the Task "CTaskVehicleEscort".
		/// </summary>
		VehicleEscort = 491,
		/// <summary>
		/// Represents the Task "CTaskVehicleHeliProtect".
		/// </summary>
		VehicleHeliProtect = 492,
		/// <summary>
		/// Represents the Task "CTaskVehiclePlayerDriveAutomobile".
		/// </summary>
		VehiclePlayerDriveAutomobile = 494,
		/// <summary>
		/// Represents the Task "CTaskVehiclePlayerDriveBike".
		/// </summary>
		VehiclePlayerDriveBike = 495,
		/// <summary>
		/// Represents the Task "CTaskVehiclePlayerDriveBoat".
		/// </summary>
		VehiclePlayerDriveBoat = 496,
		/// <summary>
		/// Represents the Task "CTaskVehiclePlayerDriveSubmarine".
		/// </summary>
		VehiclePlayerDriveSubmarine = 497,
		/// <summary>
		/// Represents the Task "CTaskVehiclePlayerDriveSubmarineCar".
		/// </summary>
		VehiclePlayerDriveSubmarineCar = 498,
		/// <summary>
		/// Represents the Task "CTaskVehiclePlayerDriveAmphibiousAutomobile".
		/// </summary>
		VehiclePlayerDriveAmphibiousAutomobile = 499,
		/// <summary>
		/// Represents the Task "CTaskVehiclePlayerDrivePlane".
		/// </summary>
		VehiclePlayerDrivePlane = 500,
		/// <summary>
		/// Represents the Task "CTaskVehiclePlayerDriveHeli".
		/// </summary>
		VehiclePlayerDriveHeli = 501,
		/// <summary>
		/// Represents the Task "CTaskVehiclePlayerDriveAutogyro".
		/// </summary>
		VehiclePlayerDriveAutogyro = 502,
		/// <summary>
		/// Represents the Task "CTaskVehiclePlayerDriveDiggerArm".
		/// </summary>
		VehiclePlayerDriveDiggerArm = 503,
		/// <summary>
		/// Represents the Task "CTaskVehiclePlayerDriveTrain".
		/// </summary>
		VehiclePlayerDriveTrain = 504,
		/// <summary>
		/// Represents the Task "CTaskVehiclePlaneChase".
		/// </summary>
		VehiclePlaneChase = 505,
		/// <summary>
		/// Represents the Task "CTaskVehicleNoDriver".
		/// </summary>
		VehicleNoDriver = 506,
		/// <summary>
		/// Represents the Task "CTaskVehicleAnimation".
		/// </summary>
		VehicleAnimation = 507,
		/// <summary>
		/// Represents the Task "CTaskVehicleConvertibleRoof".
		/// </summary>
		VehicleConvertibleRoof = 508,
		/// <summary>
		/// Represents the Task "CTaskVehicleParkNew".
		/// </summary>
		VehicleParkNew = 509,
		/// <summary>
		/// Represents the Task "CTaskVehicleFollowWaypointRecording".
		/// </summary>
		VehicleFollowWaypointRecording = 510,
		/// <summary>
		/// Represents the Task "CTaskVehicleGoToNavmesh".
		/// </summary>
		VehicleGoToNavmesh = 511,
		/// <summary>
		/// Represents the Task "CTaskVehicleReactToCopSiren".
		/// </summary>
		VehicleReactToCopSiren = 512,
		/// <summary>
		/// Represents the Task "CTaskVehicleGotoLongRange".
		/// </summary>
		VehicleGotoLongRange = 513,
		/// <summary>
		/// Represents the Task "CTaskVehicleWait".
		/// </summary>
		VehicleWait = 514,
		/// <summary>
		/// Represents the Task "CTaskVehicleReverse".
		/// </summary>
		VehicleReverse = 515,
		/// <summary>
		/// Represents the Task "CTaskVehicleBrake".
		/// </summary>
		VehicleBrake = 516,
		/// <summary>
		/// Represents the Task "CTaskVehicleHandBrake".
		/// </summary>
		VehicleHandBrake = 517,
		/// <summary>
		/// Represents the Task "CTaskVehicleTurn".
		/// </summary>
		VehicleTurn = 518,
		/// <summary>
		/// Represents the Task "CTaskVehicleGoForward".
		/// </summary>
		VehicleGoForward = 519,
		/// <summary>
		/// Represents the Task "CTaskVehicleSwerve".
		/// </summary>
		VehicleSwerve = 520,
		/// <summary>
		/// Represents the Task "CTaskVehicleFlyDirection".
		/// </summary>
		VehicleFlyDirection = 521,
		/// <summary>
		/// Represents the Task "CTaskVehicleHeadonCollision".
		/// </summary>
		VehicleHeadonCollision = 522,
		/// <summary>
		/// Represents the Task "CTaskVehicleBoostUseSteeringAngle".
		/// </summary>
		VehicleBoostUseSteeringAngle = 523,
		/// <summary>
		/// Represents the Task "CTaskVehicleShotTire".
		/// </summary>
		VehicleShotTire = 524,
		/// <summary>
		/// Represents the Task "CTaskVehicleBurnout".
		/// </summary>
		VehicleBurnout = 525,
		/// <summary>
		/// Represents the Task "CTaskVehicleRevEngine".
		/// </summary>
		VehicleRevEngine = 526,
		/// <summary>
		/// Represents the Task "CTaskVehicleSurfaceInSubmarine".
		/// </summary>
		VehicleSurfaceInSubmarine = 527,
		/// <summary>
		/// Represents the Task "CTaskVehiclePullAlongside".
		/// </summary>
		VehiclePullAlongside = 528,
		/// <summary>
		/// Represents the Task "CTaskVehicleTransformToSubmarine".
		/// </summary>
		VehicleTransformToSubmarine = 529,
		/// <summary>
		/// Represents the Task "CTaskAnimatedFallback".
		/// </summary>
		AnimatedFallback = 530
	};
}
