using System;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

namespace CQ.Multiplay
{
	public class NetworkManager : MonoBehaviourPunCallbacks
	{
		void Start()
		{
			Screen.SetResolution(800, 600, false);
			PhotonNetwork.ConnectUsingSettings();
		}

		public override void OnConnectedToMaster()
		{
			base.OnConnectedToMaster();

			PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions() {MaxPlayers = 5}, null);
			
		}

		public override void OnJoinedRoom()
		{
			base.OnJoinedRoom();

			GameObject instance = PhotonNetwork.Instantiate("Player", Vector3.zero, Quaternion.identity);
		}
	}
}