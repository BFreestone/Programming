using Debugging.Player;
using Player;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{

    public PlayerData playerData;
    public CharacterController characterController;
    //public Inventory inventory;


    private void Start()
    {
        ApplyPlayerData();
    }
    public void ApplyPlayerData()
    {
        //turn the character controller off
        characterController.enabled = false;
        //move the character position
        transform.position = playerData.playerPosition;
        //move the character rotation
        transform.rotation = Quaternion.Euler(playerData.playerRotation);
        //name the player
        gameObject.name = playerData.characterName;
        //turn on the character controller
        characterController.enabled = true;
    }


    //public void ApplyPlayerData()
    //{
    //    //turn the character controller off
    //    characterController.enabled = false;
    //    //name the player
    //    this.gameObject.name = playerData.characterName;
    //    //move the character position
    //    this.transform.position = playerData.playerPosition;
    //    //move the character rotation
    //    this.transform.rotation = Quaternion.Euler(playerData.playerRotation);
    //    //turn on the character controller
    //    characterController.enabled = true;
    //}
}
