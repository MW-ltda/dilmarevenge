using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float velocidade;
	public float forcaPulo;
	private bool estaNoChao;
	public Transform chaoVerificador;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Movimentacao();
	}

	void Movimentacao() {

		estaNoChao = Physics2D.Linecast(transform.position, chaoVerificador.position, 1 << LayerMask.NameToLayer("Piso"));
		if (Input.GetAxisRaw("Horizontal") > 0 ) {
			transform.Translate (Vector2.right * velocidade * Time.deltaTime);
			transform.eulerAngles = new Vector2(0, 0);
		}

		if (Input.GetAxisRaw("Horizontal") < 0 ) {
			transform.Translate (Vector2.right * velocidade * Time.deltaTime);
			transform.eulerAngles = new Vector2(0, 180);
		}


		Rigidbody2D rb = GetComponent<Rigidbody2D>();
		if (Input.GetButtonDown("Jump") && estaNoChao) {
			rb.AddForce(transform.up * forcaPulo);
		}
	}
}