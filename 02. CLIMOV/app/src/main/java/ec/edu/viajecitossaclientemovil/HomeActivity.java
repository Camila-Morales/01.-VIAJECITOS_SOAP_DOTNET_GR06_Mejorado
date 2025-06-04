package ec.edu.viajecitossaclientemovil;

import android.os.Bundle;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

public class HomeActivity extends AppCompatActivity {
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        TextView tv = new TextView(this);
        tv.setText("¡Bienvenido a Viajecitos SA!");
        tv.setTextSize(24);
        setContentView(tv);
    }
}