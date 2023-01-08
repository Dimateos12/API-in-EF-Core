package sample;

import javafx.animation.KeyFrame;
import javafx.animation.Timeline;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.fxml.FXML;
import javafx.scene.control.TextField;
import javafx.scene.control.Label;
import javafx.scene.shape.Circle;
import javafx.util.Duration;
import javafx.scene.paint.Color;

// automat akceptuajcy slowo nad alfabetem {a, b} zawierajacy podslowo bab
public class Controller {

    @FXML
    private TextField tvInput;
    @FXML
    private Label tvOutput, tvFinishResult;
    @FXML
    private Circle state0Circle, state1Circle, state2Circle, state3Circle;

    private final Color activeStateColor = javafx.scene.paint.Color.BLUE;
    private final Color inactiveStateColor = javafx.scene.paint.Color.WHITE;
    private final Color finalStateColor = javafx.scene.paint.Color.BLACK;

    boolean belongs = false;

    public void btnClick() {
        resetField();

        String input = tvInput.getText();


        Timeline timeline = new Timeline(new KeyFrame(Duration.seconds(1), new EventHandler<ActionEvent>() {
            int currentState = 0;
            int i = 0;
            String output = "";
            final Circle[] stateCircles = {state0Circle, state1Circle, state2Circle, state3Circle};

            // glowna petla
            @Override
            public void handle(ActionEvent actionEvent) {
                // wypisz obecny progres
                output += input.charAt(i);
                tvOutput.setText(output);

                // logika automatu
                if (currentState == 0) {
                    if (input.charAt(i) == 'b') currentState += 1;
                } else if (currentState == 1) {
                    if (input.charAt(i) == 'a') currentState += 1;
                } else if (currentState == 2) {
                    if (input.charAt(i) == 'b') {currentState += 1; belongs = true;}
                    else currentState = 0;
                }
                // oznacz stan, w ktorym obecnie sie znajduje
                setCirclesColor(stateCircles[currentState]);
                // zmien litere
                i++;
            }

            private void setCirclesColor(Circle activeCircle) {
                for (Circle stateCircle : stateCircles) {
                    if (stateCircle == activeCircle) stateCircle.setFill(activeStateColor);
                    else {
                        if (stateCircle == state3Circle) stateCircle.setFill(finalStateColor);
                        else stateCircle.setFill(inactiveStateColor);
                    }
                }
            }
        }));
        timeline.setCycleCount(input.length());
        timeline.play();
        timeline.setOnFinished(event -> {if (belongs) tvFinishResult.setText("Slowo nalezy do jezyka");
                                        else tvFinishResult.setText("Slowo nie nalezy do jezyka");});
    }

    private void resetField() {
        state0Circle.setFill(activeStateColor);
        state1Circle.setFill(inactiveStateColor);
        state2Circle.setFill(inactiveStateColor);
        state3Circle.setFill(finalStateColor);
        tvOutput.setText("");
        tvFinishResult.setText("");
        belongs = false;
    }

}
