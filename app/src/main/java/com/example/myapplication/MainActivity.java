<?xml version="1.0" encoding="utf-8"?>

<LinearLayout
xmlns:android="http://schemas.android.com/apk/res/android"
android:layout_width="match_parent"
android:layout_height="match_parent"
android:orientation="horizontal"
android:padding="10dp">

    <!-- ==================== -->
    <!-- PHẦN BÊN TRÁI        -->
    <!-- ==================== -->

    <LinearLayout
android:layout_width="0dp"
android:layout_height="match_parent"
android:layout_weight="1"
android:orientation="vertical">

        <!-- Ô TRÁI TRÊN -->
        <TextView
android:id="@+id/leftTop"
android:layout_width="match_parent"
android:layout_height="0dp"
android:layout_weight="1"
android:background="#FF9800"
android:gravity="center"
android:text="Ô 1"
android:textColor="#FFFFFF"
android:textSize="20sp" />

        <!-- Ô TRÁI DƯỚI -->
        <TextView
android:id="@+id/leftBottom"
android:layout_width="match_parent"
android:layout_height="0dp"
android:layout_weight="1"
android:background="#4CAF50"
android:gravity="center"
android:text="Ô 2"
android:textColor="#FFFFFF"
android:textSize="20sp" />

    </LinearLayout>


    <!-- ==================== -->
    <!-- PHẦN BÊN PHẢI        -->
    <!-- ==================== -->

    <LinearLayout
android:layout_width="0dp"
android:layout_height="match_parent"
android:layout_weight="1"
android:orientation="vertical">

        <!-- ==================== -->
        <!-- PHẦN TRÊN = 1/3      -->
        <!-- ==================== -->

        <TextView
android:id="@+id/rightTop"
android:layout_width="match_parent"
android:layout_height="0dp"
android:layout_weight="1"
android:background="#2196F3"
android:gravity="center"
android:text="PHẦN 1/3"
android:textColor="#FFFFFF"
android:textSize="20sp" />


        <!-- ==================== -->
        <!-- PHẦN DƯỚI = 2/3      -->
        <!-- ==================== -->

        <LinearLayout
android:layout_width="match_parent"
android:layout_height="0dp"
android:layout_weight="2"
android:orientation="vertical">

            <!-- HÀNG 1 -->
            <LinearLayout
android:layout_width="match_parent"
android:layout_height="0dp"
android:layout_weight="1"
android:orientation="horizontal">

                <!-- Ô 3 -->
                <TextView
android:id="@+id/box3"
android:layout_width="0dp"
android:layout_height="match_parent"
android:layout_weight="1"
android:background="#E91E63"
android:gravity="center"
android:text="Ô 3"
android:textColor="#FFFFFF"
android:textSize="20sp" />

                <!-- Ô 4 -->
                <TextView
android:id="@+id/box4"
android:layout_width="0dp"
android:layout_height="match_parent"
android:layout_weight="1"
android:background="#9C27B0"
android:gravity="center"
android:text="Ô 4"
android:textColor="#FFFFFF"
android:textSize="20sp" />

            </LinearLayout>


            <!-- HÀNG 2 -->
            <LinearLayout
android:layout_width="match_parent"
android:layout_height="0dp"
android:layout_weight="1"
android:orientation="horizontal">

                <!-- Ô 5 -->
                <TextView
android:id="@+id/box5"
android:layout_width="0dp"
android:layout_height="match_parent"
android:layout_weight="1"
android:background="#009688"
android:gravity="center"
android:text="Ô 5"
android:textColor="#FFFFFF"
android:textSize="20sp" />

                <!-- Ô 6 -->
                <TextView
android:id="@+id/box6"
android:layout_width="0dp"
android:layout_height="match_parent"
android:layout_weight="1"
android:background="#795548"
android:gravity="center"
android:text="Ô 6"
android:textColor="#FFFFFF"
android:textSize="20sp" />

            </LinearLayout>

        </LinearLayout>

    </LinearLayout>

</LinearLayout>