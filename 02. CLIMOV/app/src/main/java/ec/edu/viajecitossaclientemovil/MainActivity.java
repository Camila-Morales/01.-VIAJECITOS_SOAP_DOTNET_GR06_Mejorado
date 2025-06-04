package ec.edu.viajecitossaclientemovil;

import android.content.Intent;
import android.os.Bundle;
import android.os.StrictMode;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

import org.ksoap2.SoapEnvelope;
import org.ksoap2.serialization.SoapObject;
import org.ksoap2.serialization.SoapSerializationEnvelope;
import org.ksoap2.transport.HttpTransportSE;

public class MainActivity extends AppCompatActivity {

    private static final String NAMESPACE = "http://aerocondor.com/";
    private static final String METHOD_NAME = "Login";
    private static final String SOAP_ACTION = "http://aerocondor.com/Login";
    private static final String URL = "http://192.168.0.122/RestExamen/CondorService.asmx";  // Usa IP de tu backend

    EditText etUsuario, etClave;
    Button btnIngresar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main); // Asegúrate de usar el XML que te pasé

        // Habilitar llamadas en el hilo principal (solo para pruebas)
        StrictMode.setThreadPolicy(new StrictMode.ThreadPolicy.Builder().permitAll().build());

        etUsuario = findViewById(R.id.etUsuario);
        etClave = findViewById(R.id.etClave);
        btnIngresar = findViewById(R.id.btnIngresar);

        btnIngresar.setOnClickListener(v -> {
            String usuario = etUsuario.getText().toString();
            String clave = etClave.getText().toString();

            if (usuario.isEmpty() || clave.isEmpty()) {
                Toast.makeText(this, "Por favor, ingrese usuario y contraseña", Toast.LENGTH_SHORT).show();
                return;
            }

            consumirLogin(usuario, clave);
        });
    }

    private void consumirLogin(String usuario, String clave) {
        try {
            SoapObject request = new SoapObject(NAMESPACE, METHOD_NAME);
            request.addProperty("username", usuario);
            request.addProperty("password", clave);

            SoapSerializationEnvelope envelope = new SoapSerializationEnvelope(SoapEnvelope.VER11);
            envelope.dotNet = true;
            envelope.setOutputSoapObject(request);

            HttpTransportSE transporte = new HttpTransportSE(URL);
            transporte.call(SOAP_ACTION, envelope);

            Object respuesta = envelope.getResponse();

            runOnUiThread(() -> {
                String result = respuesta.toString();
                if (result.equalsIgnoreCase("OK") || result.contains("Bienvenido")) {
                    Toast.makeText(this, "Login exitoso", Toast.LENGTH_SHORT).show();
                    startActivity(new Intent(this, HomeActivity.class));  // redirige
                    finish(); // cerrar esta actividad
                } else {
                    Toast.makeText(this, "Login fallido: " + result, Toast.LENGTH_LONG).show();
                }
            });

        } catch (Exception e) {
            e.printStackTrace();
            runOnUiThread(() ->
                    Toast.makeText(this, "Error SOAP: " + e.getMessage(), Toast.LENGTH_LONG).show());
        }
    }
}